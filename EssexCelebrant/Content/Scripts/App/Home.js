(function (ns) {
    var
        // Private methods
        isTablet = function () {
            return navigator.userAgent.match(/iPad/i) !== null;
        },

        // Public methods
        init = function () {
        };

    ns.Home = {
        init: init
    };

})(window.EssexCelebrant = window.EssexCelebrant || {});