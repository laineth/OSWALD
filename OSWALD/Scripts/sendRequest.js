$("#send").click(function()
{
    $.get("http://localhost:54890/bot", function (data, status)
    {
        alert("Data: " + data + "\nStatus: " + status);
    }, "json");
});