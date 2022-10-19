'use strict';

function startInfoboxTracking() {
    document.addEventListener('mousemove', (event) => {
        // Item Infobox positioning

        let itemInfobox = document.getElementsByClassName("item-infobox")[0];

        if (document.body.contains(itemInfobox)) {
            let itemBottom = itemInfobox.offsetTop + itemInfobox.offsetHeight;

            if (window.innerHeight - itemBottom < 0 || itemBottom == window.innerHeight)
                itemInfobox.style.top = window.innerHeight - itemInfobox.offsetHeight + "px";
            else
                itemInfobox.style.top = event.y + "px";

            if (event.x > window.innerWidth / 2)
                itemInfobox.style.left = event.x - itemInfobox.offsetWidth - 10 + "px";
            else
                itemInfobox.style.left = event.x + 20 + "px";
        }

        // Facility Infobox positioning

        let facilityInfobox = document.getElementsByClassName("building-infobox")[0];

        if (document.body.contains(facilityInfobox)) {
            let facilityBottom = facilityInfobox.offsetTop + facilityInfobox.offsetHeight;

            if (window.innerHeight - facilityBottom < 0 || facilityBottom == window.innerHeight)
                facilityInfobox.style.top = window.innerHeight - facilityInfobox.offsetHeight + "px";
            else
                facilityInfobox.style.top = event.y + "px";

            if (event.x > window.innerWidth / 2)
                facilityInfobox.style.left = event.x - facilityInfobox.offsetWidth - 10 + "px";
            else
                facilityInfobox.style.left = event.x + 20 + "px";
        }

        // Facility Recipe Infobox positioning

        let recipeInfobox = document.getElementsByClassName("recipe-infobox")[0];

        if (document.body.contains(recipeInfobox)) {
            let recipeBottom = recipeInfobox.offsetTop + recipeInfobox.offsetHeight;

            if (window.innerHeight - recipeBottom < 0 || recipeBottom == window.innerHeight)
                recipeInfobox.style.top = window.innerHeight - recipeInfobox.offsetHeight + "px";
            else
                recipeInfobox.style.top = event.y + "px";

            if (event.x > window.innerWidth / 2)
                recipeInfobox.style.left = event.x - recipeInfobox.offsetWidth - 10 + "px";
            else
                recipeInfobox.style.left = event.x + 20 + "px";
        }
    });
}
