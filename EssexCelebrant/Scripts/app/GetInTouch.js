(function (ns) {
    var
        sendMessage,
        // Private methods
        sendTheMessage = function () {
            var data = { Name: $('#name').val(), Email: $('#email').val(), Message: $('#message').val() };
     

            $.ajax({
                type: "POST",
                url: "/GetInTouch/SendTheMessage",
                data: JSON.stringify(data),
                contentType: "application/json",
                dataType: "json"
            }).done(function (fuckoff) {
                alert(fuckoff);
                console.log('done');
            }).fail(function (response) {
                console.log('Error');
            });
            
        },

        // Public methods
        init = function () {
            var sendMessage = document.getElementById('send-the-message');

            sendMessage.addEventListener('click', function () {
                sendTheMessage();
            });
        };

    ns.GetInTouch = {
        init: init
    };

})(window.EssexCelebrant = window.EssexCelebrant || {});