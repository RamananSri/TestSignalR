// IIFE - namespace scope
(() => {
    var myHub = $.connection.myHub;
    var conn = $.connection.hub;

    // Klienten forbinder til hub 
    conn.start()
    .done(() => {
        console.log("It worked")
        // kalder announce() på hub (som pusher til alle clienter)
        myHub.server.announce("Hello World!");
        // kalder getdate() på hub (som kun pusher til kalder)  
        myHub.server.getDate()
        .done((data)=>{
            writeToDiv(data);
        })
        .fail((e) => {
            writeToDiv(e);
        })
    })
    .fail(() => {
        alert("Error!")
    });

    // Når announce bliver kaldt på hub kaldes denne metode (hver gang der er en der kalder announce vil der appendes en message)
    myHub.client.announce = (message) => {
        writeToDiv(message)
    }

    var writeToDiv = (message) => {
        $("#message").append(message + "<br/>");
    }

})()


