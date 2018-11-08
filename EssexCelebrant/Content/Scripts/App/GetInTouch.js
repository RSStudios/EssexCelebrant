(function (ns) {
    var
        // Private methods
        sendTheMessage = function () {
            var sendMsgButton = document.getElementById('send-the-message');
            sendMsgButton.disabled = true;

            var data = { Name: $('#name').val(), Email: $('#email').val(), Message: $('#message').val() };
     
            $.ajax({
                type: "POST",
                url: "/GetInTouch/SendTheMessage",
                data: JSON.stringify(data),
                contentType: "application/json",
                dataType: "json"
            }).done(function (data) {
                toastr.options = {
                    "closeButton": true,
                    "debug": false,
                    "newestOnTop": false,
                    "progressBar": false,
                    "positionClass": "toast-bottom-right",
                    "preventDuplicates": false,
                    "onclick": null,
                    "showDuration": "300",
                    "hideDuration": "1000",
                    "timeOut": "5000",
                    "extendedTimeOut": "1000",
                    "showEasing": "swing",
                    "hideEasing": "linear",
                    "showMethod": "fadeIn",
                    "hideMethod": "fadeOut",
                    "tapToDismiss": true
                };

                if (data.success) {
                    toastr.success('Thank you for contacting me.  I\'ll be in touch very soon.');
                }
                else {
                    toastr.error(data.errorMsg);
                }

                sendMsgButton.disabled = false;
            }).fail(function (response) {
                console.log('Error');
                sendMsgButton.disabled = false;
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