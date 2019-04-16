if (!window.flexor) {
    window.flexor = {};
}

window.flexor = {

    /**
     * Adds new CSS classes dynamically to the page.
     */
    addDynamicStyle: (className, classCSS) => {

        var styleElement = document.getElementById("flexor_dynamic_css");

        if (styleElement === null) {
            styleElement = document.createElement('style');
            styleElement.type = 'text/css';
            styleElement.id = "flexor_dynamic_css";

            document.head.appendChild(styleElement);
        }

        if (!styleElement.innerHTML.includes(className)) {
            styleElement.innerHTML += " " + classCSS;
        }

    }
};