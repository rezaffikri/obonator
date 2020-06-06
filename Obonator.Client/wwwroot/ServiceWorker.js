const baseURL = '/dev/';
const indexURL = '/dev/index.html';
const networkFetchEvent = 'fetch';
const swInstallEvent = 'install';
const swInstalledEvent = 'installed';
const swActivateEvent = 'activate';
const staticCachePrefix = 'blazor-cache-v';
const staticCacheName = 'blazor-cache-v8';
const requiredFiles = [
"/dev/_framework/blazor.boot.json",
"/dev/_framework/blazor.webassembly.js",
"/dev/_framework/wasm/dotnet.js",
"/dev/_framework/wasm/dotnet.wasm",
"/dev/_framework/_bin/Blazored.LocalStorage.dll",
"/dev/_framework/_bin/Blazored.Toast.dll",
"/dev/_framework/_bin/Blazorise.Bulma.dll",
"/dev/_framework/_bin/Blazorise.DataGrid.dll",
"/dev/_framework/_bin/Blazorise.dll",
"/dev/_framework/_bin/Blazorise.Icons.FontAwesome.dll",
"/dev/_framework/_bin/Microsoft.AspNetCore.Authorization.dll",
"/dev/_framework/_bin/Microsoft.AspNetCore.Blazor.dll",
"/dev/_framework/_bin/Microsoft.AspNetCore.Blazor.HttpClient.dll",
"/dev/_framework/_bin/Microsoft.AspNetCore.Components.Authorization.dll",
"/dev/_framework/_bin/Microsoft.AspNetCore.Components.dll",
"/dev/_framework/_bin/Microsoft.AspNetCore.Components.Forms.dll",
"/dev/_framework/_bin/Microsoft.AspNetCore.Components.Web.dll",
"/dev/_framework/_bin/Microsoft.AspNetCore.Metadata.dll",
"/dev/_framework/_bin/Microsoft.Bcl.AsyncInterfaces.dll",
"/dev/_framework/_bin/Microsoft.Extensions.Configuration.Abstractions.dll",
"/dev/_framework/_bin/Microsoft.Extensions.Configuration.dll",
"/dev/_framework/_bin/Microsoft.Extensions.DependencyInjection.Abstractions.dll",
"/dev/_framework/_bin/Microsoft.Extensions.DependencyInjection.dll",
"/dev/_framework/_bin/Microsoft.Extensions.Logging.Abstractions.dll",
"/dev/_framework/_bin/Microsoft.Extensions.Options.dll",
"/dev/_framework/_bin/Microsoft.Extensions.Primitives.dll",
"/dev/_framework/_bin/Microsoft.JSInterop.dll",
"/dev/_framework/_bin/Mono.Security.dll",
"/dev/_framework/_bin/Mono.WebAssembly.Interop.dll",
"/dev/_framework/_bin/mscorlib.dll",
"/dev/_framework/_bin/Obonator.Client.dll",
"/dev/_framework/_bin/Obonator.Client.pdb",
"/dev/_framework/_bin/Obonator.Library.dll",
"/dev/_framework/_bin/Obonator.Library.pdb",
"/dev/_framework/_bin/Obonator.Shared.dll",
"/dev/_framework/_bin/Obonator.Shared.pdb",
"/dev/_framework/_bin/System.ComponentModel.DataAnnotations.dll",
"/dev/_framework/_bin/System.Core.dll",
"/dev/_framework/_bin/System.dll",
"/dev/_framework/_bin/System.Drawing.Common.dll",
"/dev/_framework/_bin/System.Net.Http.dll",
"/dev/_framework/_bin/System.Runtime.CompilerServices.Unsafe.dll",
"/dev/_framework/_bin/System.Text.Encodings.Web.dll",
"/dev/_framework/_bin/System.Text.Json.dll",
"/dev/_framework/_bin/System.Xml.dll",
"/dev/_framework/_bin/WebAssembly.Bindings.dll",
"/dev/_framework/_bin/WebAssembly.Net.Http.dll",
"/dev/css/blazored-toast-custom.css",
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
