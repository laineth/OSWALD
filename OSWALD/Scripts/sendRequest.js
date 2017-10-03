$(document).ready(function()
{
    var botName = "Oswin";
    var punctuation = ": ";
    var name = botName + punctuation;

    document.getElementById('chat').value = name + 'I am here, to help you gather information about Thomas.';

    $("#send").click(function()
    {
        $.get("http://localhost:54890/bot", function (data, status)
        {
            alert("Data: " + data + "\nStatus: " + status);
        }, "json");
    });
});