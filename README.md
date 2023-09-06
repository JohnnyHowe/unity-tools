# Extensions
## GraphicSetAlpha
Instead of having to cache the color of a UI image (or any other Graphic) to change the alpha like this.
```
Color c = image.color;
c.a = newAlpha;
image.color = c;
```
As long as the `Extensions/GraphicSetAlpha.cs` is somewhere in your project, replace the above with just
```
image.SetAlpha(newAlpha);
```
