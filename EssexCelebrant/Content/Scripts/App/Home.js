(function (ns) {
    var
        // Private methods
        toggleMenuForPhone = function () {
            var nav = document.getElementsByTagName("nav");
            var header = document.getElementById("header");
            var container = document.getElementsByClassName("container");
            var menuBeingDisplayed = document.getElementsByClassName('menu-being-displayed');

            if (menuBeingDisplayed.length === 0) {
                header.classList.add('menu-being-displayed');
                header.classList.add('show-menu');
                container[1].classList.add('show-menu');
                nav[0].classList.add('show-menu');
            }
            else {
                header.classList.remove('show-menu');
                container[1].classList.remove('show-menu');
                nav[0].classList.remove('show-menu');
                header.classList.remove('menu-being-displayed');
            }
        },
        toggleMenuForTablet = function () {
            var nav = document.getElementsByTagName("nav");
            var glennTitle = document.getElementsByClassName("glenn-title");
            var menuBeingDisplayed = document.getElementsByClassName('menu-being-displayed');

            if (menuBeingDisplayed.length === 0) {
                glennTitle[0].classList.add('menu-being-displayed');
                glennTitle[0].classList.add('show-menu');
                nav[0].classList.add('show-menu');
            }
            else {
                nav[0].classList.remove('show-menu');
                glennTitle[0].classList.remove('show-menu');
                glennTitle[0].classList.remove('menu-being-displayed');
            }
        },
        isTablet = function () {
            return navigator.userAgent.match(/iPad/i) !== null;
        },

        // Public methods
        init = function () {
            var menuButton = document.getElementById('menu-button');

            menuButton.addEventListener('click', function () {
                if (isTablet()) {
                    toggleMenuForTablet();
                }
                else {
                    toggleMenuForPhone();
                }
            });
        };

    ns.Home = {
        init: init
    };

})(window.EssexCelebrant = window.EssexCelebrant || {});