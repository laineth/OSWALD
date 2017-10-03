$('#oswin').submit(function(event)
{
    event.preventDefault();

    var u_input = $('#user_entry').val();
    var t = $('#chat').val();

    if (t[0] == ' ')
        $('#chat').val("You: " + u_input);
    else
        $('#chat').val(t + "\nYou: " + u_input);


});