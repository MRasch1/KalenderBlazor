window.blazorApp = {
    registerShortcut: function (key, method) {
        console.log("Registering shortcut for key: " + key);
        document.addEventListener("keydown", function (event) {
            console.log("Key pressed: " + event.key);
            if (event.key === key) {
                console.log("Invoking method: " + method);
                DotNet.invokeMethodAsync("Kalender", method);
            }
        });
    }
};
