$(document).ready(function()
{
    var botName = "Oswin";
    var punctuation = ": ";
    var name = botName + punctuation;

    document.getElementById('chat').value = name + 'I am here, to help you gather information about Thomas.';

    $("#send").click(function()
    {
        var u_input = $('#user_entry').val();

        // Make a POST request to host/bot endpoint
        // Send u_input with the request, so the server can process what the user said
        jQuery.ajax({
            url: "http://localhost:54890/bot",
            type: "POST",
            data: JSON.stringify({ value: u_input }),
            dataType: "json",
            contentType: "application/json; charset=utf-8",
            success: function (data, status)
            {
                console.log("Data: " + data + "\nStatus: " + status);
            }
        });
    });
});