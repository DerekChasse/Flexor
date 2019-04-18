if (!window.flexor) {
    window.flexor = {};
}

window.flexor = {

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
    },
       
    decorateChild: (divId, classesString) => {
        var divElement = document.getElementById(divId);

        var child = divElement.firstElementChild;

        var classes = classesString.split(' ');

        child.classList.add(...classes);
    },

    unwrapDiv: (divId) => {

        var divElement = document.getElementById(divId);

        // place childNodes in document fragment
        var documentFragment = document.createDocumentFragment();

        while (wrapper.firstChild) {
            var child = wrapper.removeChild(divElement.firstChild);

            documentFragment.appendChild(child);
        }

        // replace wrapper with document fragment
        divElement.parentNode.replaceChild(documentFragment, divElement);
    }
};