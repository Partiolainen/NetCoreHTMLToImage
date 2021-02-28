# .NET Core HTML to Image converter

This is a .NET Core HTML to Image converter. It helps converting HTML strings or URLs to image bytes. Please see the examples:

## Installation Instructions
Nuget package available (https://www.nuget.org/packages/NetCoreHTMLToImage)
```
Install-Package NetCoreHTMLToImage
```

## Convert HTML string to image bytes
```
var converter = new HtmlConverter();
var html = "<div><strong>Hello</strong> World!</div>";
var bytes = converter.FromHtmlString(html);
File.WriteAllBytes("image.jpg", bytes);
```
            
## Convert URL to image bytes
```
var converter = new HtmlConverter();
var bytes = converter.FromUrl("http://google.com");
File.WriteAllBytes("image.jpg", bytes);
```

## Optional parameters
1. width - output document width. Default is 1024.
2. format - output image format. Default is Jpg.
3. quality - output image quality from 1 to 100. Default is 100.

## Roadmap
* Async interface

## More about this library
This is [andrei-m-code library](https://github.com/andrei-m-code/net-core-html-to-image) rework

## For Ubuntu users
```
sudo wget https://github.com/wkhtmltopdf/packaging/releases/download/0.12.6-1/wkhtmltox_0.12.6-1.buster_amd64.deb
sudo dpkg -i wkhtmltox_0.12.6-1.buster_amd64.deb
sudo apt-get install -f
sudo ln -s /usr/local/bin/wkhtmltopdf /usr/bin
sudo ln -s /usr/local/bin/wkhtmltoimage /usr/bin
```
