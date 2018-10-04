(function () {

    var EssexCelebrant = window.EssexCelebrant = window.EssexCelebrant || {};

    EssexCelebrant.VenuesVM = function (venueData) {
        var self = this;
        self.venues = ko.observableArray(venueData);

        self.clearSearchFilters = function () {
         
        };

        self.runAdvancedSearch = function () {

        };

        self.getAdvancedSearchMetaData = function () {
           
        };

        // Init
        self.getAdvancedSearchMetaData();

        $('#left-column').hide();
        $('#middle-column').addClass('expanded');
    }
})();

