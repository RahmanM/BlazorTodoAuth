
window.applyAnnimation = (id, annimationName) => {
    var element = document.getElementById(id);

    if (!element.classList.contains(annimationName)) {
        element.className += " cssanimation " + annimationName;
    }

    setTimeout(function () {
        element.classList.remove('cssanimation', annimationName);
    }, 2000)
};

window.applyAnnimation = (id, annimationName, durationMiliSeconds) => {
    var duration = durationMiliSeconds ? durationMiliSeconds : 2000;
    var element = document.getElementById(id);
    if (!element.classList.contains(annimationName)) {
        element.className += " cssanimation " + annimationName;
    }

    setTimeout(function () {
        element.classList.remove('cssanimation', annimationName);
    }, duration)
};

window.applyAnnimationNoDuration = (id, annimationName) => {
    var element = document.getElementById(id);

    if (!element.classList.contains(annimationName)) {
        element.className += " cssanimation " + annimationName;
    }
};

window.removeAnimation = (id, annimationName) => {
    var element = document.getElementById(id);
    element.classList.remove('cssanimation', annimationName);
};

window.addCssClass = (id, className) => {
    var element = document.getElementById(id);
    if (!element.classList.contains(className)) {
        element.className += "  " + className;
    }
};

window.removeCssClass = (id, className) => {
    var element = document.getElementById(id);
    element.classList.remove(className);
};