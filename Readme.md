# Chromecast YouTube caster
Makes it really easy to cast youtube videos to your Chromecast device:

```cs
// *** For now use the Google home app to find your ip or use a library like SharpCaster ***
var chromecastYouTubeCaster = new ChromecastYouTubeCaster("192.168.1.235");

var resp = await chromecastYouTubeCaster.PlayVideo("RDfjXj5EGqI");
```