
window.applyAnnimation = (id, annimationName) => {
    var element = document.getElementById(id);
    element.className += "cssanimation " + annimationName;

    setTimeout(function () {
        element.classList.remove('cssanimation', annimationName);
    }, 2000)
};

window.applyAnnimation = (id, annimationName, durationMiliSeconds) => {
    var duration = durationMiliSeconds ? durationMiliSeconds : 2000;
    var element = document.getElementById(id);
    element.className += "cssanimation " + annimationName;

    setTimeout(function () {
        element.classList.remove('cssanimation', annimationName);
    }, duration)
};
