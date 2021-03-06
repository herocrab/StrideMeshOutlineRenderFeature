# StrideMeshOutlineRenderFeature
This is a simple outline renderer for Stride.

<img src="screenshot.png">

1) Clone the project.
2) Explore the compositor render features.
3) Expand the MeshOutlineRenderFeature properties. Note the RenderGroupMask.
4) Explore entities in the scene with the outline entity component attached.

 <img src="compositor1.png">
 
 <img src="compositor2.png">
 
 <img src="outline_component.png">

How it works:
1) Mesh outline render feature adds a dynamic shader effect to the pipeline for specific render groups.
2) Mesh outline render feature increases size of rendered objects.
3) Rendered objects are saturated to a color AND intensity specified by the outline entity component.
4) Rendered "outline" objects are rendered with CullMode.Front, so they are behind objects.

