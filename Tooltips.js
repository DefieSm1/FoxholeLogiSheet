'use strict';

document.addEventListener('mousemove', event => {
    for (let tooltip of document.getElementsByClassName("item-tooltip")) {
        let itemBottom = tooltip.offsetTop + tooltip.offsetHeight;

        if (window.innerHeight - itemBottom < 0 || itemBottom == window.innerHeight)
            tooltip.style.top = window.innerHeight - tooltip.offsetHeight + "px";
        else
            tooltip.style.top = event.y + "px";

        if (event.x > window.innerWidth / 2)
            tooltip.style.left = event.x - tooltip.offsetWidth - 10 + "px";
        else
            tooltip.style.left = event.x + 20 + "px";
        }
});
