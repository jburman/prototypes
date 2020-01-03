window.registerKeyboard = function (component) {
    window.keyboardComponent = component;

    function toDotNetArg(ev) {
        return {
            Key: ev.key,
            Code: ev.code,
            Location: ev.location,
            Repeat: ev.repeat,
            CtrlKey: ev.ctrlKey,
            ShiftKey: ev.shiftKey,
            AltKey: ev.altKey,
            MetaKey: ev.metaKey,
            Type: ev.type
        };
    }

    document.addEventListener("keydown", function (ev) {
        if (ev.key !== "F12") {
            ev.preventDefault();
        }
        console.info(ev);
        window.keyboardComponent.invokeMethodAsync("OnKeyDown", toDotNetArg(ev));

        return false;
    });

    document.addEventListener("keyup", function (ev) {
        ev.preventDefault();
        console.info(ev);
        window.keyboardComponent.invokeMethodAsync("OnKeyUp", toDotNetArg(ev));

        return false;
    });
};