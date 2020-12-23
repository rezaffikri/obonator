const baseURL = '/dev/';
const indexURL = '/dev/index.html';
const networkFetchEvent = 'fetch';
const swInstallEvent = 'install';
const swInstalledEvent = 'installed';
const swActivateEvent = 'activate';
const staticCachePrefix = 'blazor-cache-v';
const staticCacheName = 'blazor-cache-v5';
const requiredFiles = [
"/dev/404.html",
"/dev/css/app.css",
"/dev/css/blazored-toast-custom.css",
"/dev/css/bootstrap/bootstrap.min.css",
"/dev/css/bootstrap/bootstrap.min.css.map",
"/dev/css/font-open-sans.css",
"/dev/css/login.css",
"/dev/css/minireset.css",
"/dev/css/obon.css",
"/dev/css/obonbaselayout.css",
"/dev/css/obonbox.css",
"/dev/css/obonbulma.css",
"/dev/css/oboncard.css",
"/dev/css/oboncolumns.css",
"/dev/css/oboncustom.css",
"/dev/css/open-iconic/FONT-LICENSE",
"/dev/css/open-iconic/font/css/open-iconic-bootstrap.min.css",
"/dev/css/open-iconic/font/fonts/open-iconic.eot",
"/dev/css/open-iconic/font/fonts/open-iconic.otf",
"/dev/css/open-iconic/font/fonts/open-iconic.svg",
"/dev/css/open-iconic/font/fonts/open-iconic.ttf",
"/dev/css/open-iconic/font/fonts/open-iconic.woff",
"/dev/css/open-iconic/ICON-LICENSE",
"/dev/css/open-iconic/README.md",
"/dev/favicon.ico",
"/dev/img/icon-obon192.png",
"/dev/img/icon-obon512.png",
"/dev/img/logo.jpg",
"/dev/img/not_auth.jpg",
"/dev/img/splash-screen-cat-loading.gif",
"/dev/index.html",
"/dev/js/font-awesome.js",
"/dev/ServiceWorkerRegister.js",
"/dev/manifest.json"
];
// * listen for the install event and pre-cache anything in filesToCache * //
self.addEventListener(swInstallEvent, event => {
    self.skipWaiting();
    event.waitUntil(
        caches.open(staticCacheName)
            .then(cache => {
                return cache.addAll(requiredFiles);
            })
    );
});
self.addEventListener(swActivateEvent, function (event) {
    event.waitUntil(
        caches.keys().then(function (cacheNames) {
            return Promise.all(
                cacheNames.map(function (cacheName) {
                    if (staticCacheName !== cacheName && cacheName.startsWith(staticCachePrefix)) {
                        return caches.delete(cacheName);
                    }
                })
            );
        })
    );
});
self.addEventListener(networkFetchEvent, event => {
    const requestUrl = new URL(event.request.url);
    if (requestUrl.origin === location.origin) {
        if (requestUrl.pathname === baseURL) {
            event.respondWith(caches.match(indexURL));
            return;
        }
    }
    event.respondWith(
        caches.match(event.request)
            .then(response => {
                if (response) {
                    return response;
                }
                return fetch(event.request)
                    .then(response => {
                        if (response.ok) {
                            if (requestUrl.origin === location.origin) {
                                caches.open(staticCacheName).then(cache => {
                                    cache.put(event.request.url, response);
                                });
                            }
                        }
                        return response.clone();
                    });
            }).catch(error => {
                console.error(error);
            })
    );
});
