<h1 align="center">Webhook Configuration</h1>
<div>
  <img alt="C#" src="https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white" />
  <img alt=".NET" src="https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white" />
</div>
<div>
 <div>
    <h3>How to configure telegram webhook in asp.net core ?</h3>
  <ol>
    <li> go to <code>BotSettings.json</code> and paste your Token</li>
    <li> open your <code>ngrok</code> and type this command :</li>
    <br>
    <div class="highlight highlight-source-shell notranslate position-relative overflow-auto" dir="auto" align="left">
        <pre>ngrok http <'port'> --host-header="localhost:<'port'>"</pre>
    </div>
    <li>copy the public tunnel wich ngrok gave you and paste in <code>Message/BotConfigure</code> parameters </li>
  </ol>
          <hr>

  <a>Now,the webhook url is set and telegram bot is configured,enjoy</a>
 </div>
</div>
