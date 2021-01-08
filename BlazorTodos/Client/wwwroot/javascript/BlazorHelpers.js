
window.todoCompletedAnimation = (id) => {
    var element = document.getElementById(id);
    element.className += "cssanimation zoomIn";

    setTimeout(function () {
        element.classList.remove('cssanimation', 'zoomIn');
    }, 2000)
};

window.deleteAnimation = (id) => {
    var element = document.getElementById(id);
    element.className += "cssanimation blurOut";

    //setTimeout(function () {
    //    element.classList.remove('cssanimation', 'zoomIn');
    //}, 2000)
};
