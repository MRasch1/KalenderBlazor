namespace Kalender.wwwroot
{
    public class KeyListen
    {
        window.customFunctions = {
            addEventListener: function (callback) {
                document.addEventListener("keydown", callback);
            }
        };
    }
}
