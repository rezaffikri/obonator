const baseURL = '/obonator/';
const indexURL = '/obonator/index.html';
const networkFetchEvent = 'fetch';
const swInstallEvent = 'install';
const swInstalledEvent = 'installed';
const swActivateEvent = 'activate';
const staticCachePrefix = 'blazor-cache-v';
const staticCacheName = 'blazor-cache-v3';
const requiredFiles = [
"/obonator/404.html",
"/obonator/css/app.css",
"/obonator/css/blazored-toast-custom.css",
"/obonator/css/bootstrap/bootstrap.min.css",
"/obonator/css/bootstrap/bootstrap.min.css.map",
"/obonator/css/font-open-sans.css",
"/obonator/css/login.css",
"/obonator/css/minireset.css",
"/obonator/css/obon.css",
"/obonator/css/obonbaselayout.css",
"/obonator/css/obonbox.css",
"/obonator/css/obonbulma.css",
"/obonator/css/oboncard.css",
"/obonator/css/oboncolumns.css",
"/obonator/css/oboncustom.css",
"/obonator/css/open-iconic/FONT-LICENSE",
"/obonator/css/open-iconic/font/css/open-iconic-bootstrap.min.css",
"/obonator/css/open-iconic/font/fonts/open-iconic.eot",
"/obonator/css/open-iconic/font/fonts/open-iconic.otf",
"/obonator/css/open-iconic/font/fonts/open-iconic.svg",
"/obonator/css/open-iconic/font/fonts/open-iconic.ttf",
"/obonator/css/open-iconic/font/fonts/open-iconic.woff",
"/obonator/css/open-iconic/ICON-LICENSE",
"/obonator/css/open-iconic/README.md",
"/obonator/favicon.ico",
"/obonator/img/icon-obon192.png",
"/obonator/img/icon-obon512.png",
"/obonator/img/logo.jpg",
"/obonator/img/not_auth.jpg",
"/obonator/img/splash-screen-cat-loading.gif",
"/obonator/index.html",
"/obonator/js/font-awesome.js",
"/obonator/ServiceWorkerRegister.js",
"/obonator/manifest.json"
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
