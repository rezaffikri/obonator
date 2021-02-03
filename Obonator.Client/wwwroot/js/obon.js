window.clipboardTextCopy = {
    copyText: async function (text) {
        var result = "";
        await navigator.clipboard.writeText(text).then(function () {

        })
            .catch(function (error) {
                result = error.message;
            });
        return result;
    }
};

window.clipboardElementCopy = {
    copyText: async function (codeElement) {
        var result = "";
        await navigator.clipboard.writeText(codeElement.textContent).then(function () {

        })
            .catch(function (error) {
                result = error.message;
            });
        return result;
    }
}

//window.selectLiveSearch = (selectId) => {
//    document.getElementById("selectId").selectize();
//}