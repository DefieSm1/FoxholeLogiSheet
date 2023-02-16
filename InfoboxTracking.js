'use strict';

document.addEventListener('mousemove', event => {
    for (let infobox of document.getElementsByClassName("infobox")) {
        let itemBottom = infobox.offsetTop + infobox.offsetHeight;

        if (window.innerHeight - itemBottom < 0 || itemBottom == window.innerHeight)
            infobox.style.top = window.innerHeight - infobox.offsetHeight + "px";
        else
            infobox.style.top = event.y + "px";

        if (event.x > window.innerWidth / 2)
            infobox.style.left = event.x - infobox.offsetWidth - 10 + "px";
        else
            infobox.style.left = event.x + 20 + "px";
        }
});
