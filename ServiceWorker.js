const baseURL = '/';
const indexURL = '/index.html';
const networkFetchEvent = 'fetch';
const swInstallEvent = 'install';
const swInstalledEvent = 'installed';
const swActivateEvent = 'activate';
const staticCachePrefix = 'blazor-cache-v';
const staticCacheName = 'blazor-cache-v1';
const requiredFiles = [
"/404.html",
"/css/app.css",
"/css/blazored-toast-custom.css",
"/css/bootstrap/bootstrap.min.css",
"/css/bootstrap/bootstrap.min.css.map",
"/css/font-open-sans.css",
"/css/login.css",
"/css/minireset.css",
"/css/obon.css",
"/css/obonbaselayout.css",
"/css/obonbox.css",
"/css/obonbulma.css",
"/css/oboncard.css",
"/css/oboncolumns.css",
"/css/oboncustom.css",
"/css/open-iconic/FONT-LICENSE",
"/css/open-iconic/font/css/open-iconic-bootstrap.min.css",
"/css/open-iconic/font/fonts/open-iconic.eot",
"/css/open-iconic/font/fonts/open-iconic.otf",
"/css/open-iconic/font/fonts/open-iconic.svg",
"/css/open-iconic/font/fonts/open-iconic.ttf",
"/css/open-iconic/font/fonts/open-iconic.woff",
"/css/open-iconic/ICON-LICENSE",
"/css/open-iconic/README.md",
"/favicon.ico",
"/img/icon-obon192.png",
"/img/icon-obon512.png",
"/img/logo.jpg",
"/img/not_auth.jpg",
"/img/splash-screen-cat-loading.gif",
"/index.html",
"/js/font-awesome.js",
"/ServiceWorkerRegister.js",
"/manifest.json"
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
