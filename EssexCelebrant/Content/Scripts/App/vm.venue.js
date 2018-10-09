(function () {
    ko.observableArray.fn.distinct = function (prop) {
        var target = this;
        target.index = {};
        target.index[prop] = ko.observable({});

        ko.computed(function () {
            //rebuild index
            var propIndex = {};

            ko.utils.arrayForEach(target(), function (item) {
                var key = ko.utils.unwrapObservable(item[prop]);
                if (key) {
                    propIndex[key] = propIndex[key] || [];
                    propIndex[key].push(item);
                }
            });

            target.index[prop](propIndex);
        });

        return target;
    };    

    var EssexCelebrant = window.EssexCelebrant = window.EssexCelebrant || {};

    EssexCelebrant.VenuesVM = function (venueData, counties) {
        var self = this;
        self.masterVenues = ko.observableArray(venueData);
        self.filteredVenues = ko.observableArray(venueData).distinct('county');
        self.allCounties = ko.observableArray(counties);

        self.clearSearchFilters = function () {

        };

        self.runAdvancedSearch = function () {

        };

        self.searchForText = function () {
            var searchTerm = this.value.toLowerCase();
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

