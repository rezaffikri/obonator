const baseURL = '/dev/';
const indexURL = '/dev/index.html';
const networkFetchEvent = 'fetch';
const swInstallEvent = 'install';
const swInstalledEvent = 'installed';
const swActivateEvent = 'activate';
const staticCachePrefix = 'blazor-cache-v';
const staticCacheName = 'blazor-cache-v10';
const requiredFiles = [
"/dev/404.html",
"/dev/css/app.css",
"/dev/css/blazored-toast-custom.css",
"/dev/css/bulmacustom.css",
"/dev/css/font-open-sans.css",
"/dev/css/login.css",
"/dev/css/minireset.css",
"/dev/css/obon.css",
"/dev/favicon.ico",
"/dev/img/icon-obon192.png",
"/dev/img/icon-obon512.png",
"/dev/img/logo.jpg",
"/dev/img/not_auth.gif",
"/dev/img/not_auth.jpg",
"/dev/img/not_found.gif",
"/dev/img/not_found.jpg",
"/dev/img/splash-screen-cat-loading.gif",
"/dev/index.html",
"/dev/js/font-awesome.js",
"/dev/js/obon.js",
"/dev/lib/bulma/css/bulma-rtl.css",
"/dev/lib/bulma/css/bulma-rtl.css.map",
"/dev/lib/bulma/css/bulma-rtl.min.css",
"/dev/lib/bulma/css/bulma.css",
"/dev/lib/bulma/css/bulma.css.map",
"/dev/lib/bulma/css/bulma.min.css",
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
