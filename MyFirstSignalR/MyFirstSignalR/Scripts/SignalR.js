// Klienten forbinder til hub 
$.connection.hub.start()
.done(() => {
    console.log("It worked")
    // kalder announce() metoden på hub (som pusher til alle clienter)
    $.connection.myHub.server.announce("Hello World!");
})
.fail(() => {
    alert("Error!")
});

// Når announce bliver kaldt på hub kaldes denne metode (hver gang der er en der kalder announce vil der appendes en message)
$.connection.myHub.client.announce = (message) => {
    $("#message").append(message + "<br/>");
}


