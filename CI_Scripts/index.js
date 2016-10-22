module.exports = function (context, data) {
    
    var lastContext = JSON.parse(data[0].last_context);
    var commitId = (lastContext.id).substring(0,7);
    var statusId = lastContext.status;
    var message = lastContext.message;
    var cutmessage = message.substring(0, message.length - 1);
    var author = lastContext.author;

    

    var linkId = "https://github.com/fullstack101/harabiika/commit/" + commitId

   
      
var request = require('request');
if(data) {
    var slackUrl = "https://hooks.slack.com/services/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";
   
    var text = {
     "text" : "Build <" + linkId +"|" + commitId + "> (" + cutmessage + ") " + statusId + " Author " + author
    };
 
    var requestData = {
        url: slackUrl,
        method: "POST",
        json: true,
        headers: {
            "content-type": "application/json",
        },
        body: text
    };
 
    request(requestData);
    context.res = {
        status: 200
    };

    }
    else {
        context.res = {
            status: 400,
            body: { error: 'Please pass first/last properties in the input object'}
        };
    }

    context.done();
}
