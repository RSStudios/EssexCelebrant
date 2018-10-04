(function () {

    var EssexCelebrant = window.EssexCelebrant = window.EssexCelebrant || {};

    EssexCelebrant.VenuesVM = function (venueData) {
        var self = this;
        self.masterVenues = ko.observableArray(venueData);
        self.filteredVenues = ko.observableArray(venueData);

        self.clearSearchFilters = function () {

        };

        self.runAdvancedSearch = function () {

        };

        self.searchForText = function () {
            var searchTerm = this.value;
            if (searchTerm === "") {
                self.filteredVenues(self.masterVenues());
            }
            else {
                self.filteredVenues(self.masterVenues().filter(allVenues => {
                    if (allVenues.county.toLowerCase().includes(searchTerm)) {
                        return true;
                    }
                    else if (allVenues.venue.toLowerCase().includes(searchTerm)) {
                        return true;
                    }
                }));
            }
        };

        // Init
        var searchText = document.getElementById("search-text");
        searchText.addEventListener("keyup", self.searchForText, false);
    }
})();

