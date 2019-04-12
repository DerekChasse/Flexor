if (!window.flexor) {
    window.flexor = {};
}

window.flexor = {

    /**
     * Adds new CSS classes dynamically to the page.
     */
    addDynamicStyle: (rawCSS) => {
        var style = document.createElement('style');

        style.type = 'text/css';
        style.innerHTML = rawCSS;

        document.head.appendChild(style);
    }
};