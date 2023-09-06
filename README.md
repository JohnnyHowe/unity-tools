# Utils
## VectorUtils.UnsafeLerp
For both `Vector2` and `Vector3`. Interpolates and extrapolates. For example
```
Vector3.Lerp(Vector3.zero, Vector3.one, 2)      => Vector3(1, 1, 1)
VectorUtils.Lerp(Vector3.zero, Vector3.one, 2)  => Vector3(2, 2, 2)
```
Works in negative values too.
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
