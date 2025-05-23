# Unlit Material Inspector reference

You can modify the properties of an Unlit material in the Unlit Material Inspector.

Refer to [Unlit material](unlit-material.md) for more information.

## Properties

### Surface Options

Surface options control the overall look of your Material's surface and how Unity renders the Material on screen.

| Property| Description |
|:---|:---|
| **Surface type** | Use the drop-down to define whether your Material supports transparency or not. Materials with a **Transparent Surface Type** are more resource intensive to render than Materials with an **Opaque** **Surface Type**. HDRP exposes more properties, depending on the **Surface Type** you select. For more information about the feature and for the list of properties each **Surface Type** exposes, see the [Surface Type documentation](Surface-Type.md). |
| **- Render Pass** | Use the drop-down to set the rendering pass that HDRP processes this Material in. For information on this property, see the [Surface Type documentation](Surface-Type.md). |
| **Double-Sided**   | Enable the checkbox to make HDRP render both faces of the polygons in your geometry. For more information about the feature and for the  list of properties this feature exposes, see the [Double-Sided documentation](Double-Sided.md). |
| **Alpha Clipping** | Enable the checkbox to make this Material act like a [Cutout Shader](https://docs.unity3d.com/Manual/StandardShaderMaterialParameterRenderingMode.html). Enabling this feature exposes more properties. For more information about the feature and for the  list of properties this feature exposes, see the [Alpha Clipping documentation](Alpha-Clipping.md). |


### Surface Inputs

| Property| Description |
|:---|:---|
| **Color** | The texture and base color of the Material. The RGB values define the color and the alpha channel defines the opacity. If you set a texture to this field, HDRP multiplies the texture by the color. If you do not set a texture in this field then HDRP only uses the base color to draw Meshes that use this Material.|
| **- Tiling** | HDRP uses the **X** and **Y** values of this property to tile the texture set as the **Color** property along the object space x-axis and y-axis respectively. |
| **- Offset** | HDRP uses the **X** and **Y** values of this property to offset the texture set as the **Color** property along the object space x-axis and y-axis respectively. |

### Emission Inputs

| **Property**               | **Description**                                              |
| -------------------------- | ------------------------------------------------------------ |
| **Use Emission Intensity** | Enable the checkbox to use a separate LDR color and intensity value to set the emission color for this Material. Disable this checkbox to only use an HDR color to handle the color and emission color intensity. When enabled, this exposes the **Emission Intensity** property. |
| **Emissive Color**         | Assign a Texture that this Material uses for emission. You can also use the color picker to select a color that HDRP multiplies by the Texture. If you do not set an emission texture then HDRP only uses the HDR color to calculate the final emissive color of the Material. You can set the intensity of the HDR color within the HDR color picker. |
| **- Tiling**               | Set an **X** and **Y** tile rate for the **Emissive Color** UV. HDRP uses the **X** and **Y** values to tile the Texture assigned to the **Emissive Color** across the Material’s surface, in object space. |
| **- Offset**               | Set an **X** and **Y** offset for the **Emissive Color** UV. HDRP uses the **X** and **Y** values to offset the Texture assigned to the **Emissive Color** across the Material’s surface, in object space. |
| **Emission Intensity**     | Set the overall strength of the emission effect for this Material.<br />Use the drop-down to select one of the following [physical light units](Physical-Light-Units.md) to use for intensity:<br />&#8226; [Luminance](Physical-Light-Units.md)<br />&#8226; [EV<sub>100</sub>](Physical-Light-Units.md#EV) |
| **Exposure Weight**        | Use the slider to set how much effect the exposure has on the emission power. For example, if you create a neon tube, you would want to apply the emissive glow effect at every exposure. |
| **Emission**               | Toggles whether emission affects global illumination. |
| **- Global Illumination**  | The mode HDRP uses to determine how color emission interacts with global illumination.<br />&#8226; **Realtime**: Select this option to make emission affect the result of real-time global illumination.<br />&#8226; **Baked**: Select this option to make emission only affect global illumination during the baking process.<br />&#8226; **None**: Select this option to make emission not affect global illumination. |

### Transparency Inputs

Unity exposes this section if you select **Transparent** from the **Surface Type** drop-down. For information on the properties in this section, see the [Surface Type documentation](Surface-Type.md#TransparencyInputs).

### Advanced Options

| Property| Description |
|:---|:---|
| **Enable GPU instancing** | Enable the checkbox to tell HDRP to render Meshes with the same geometry and Material in one batch when possible. This makes rendering faster. HDRP cannot render Meshes in one batch if they have different Materials, or if the hardware does not support GPU instancing. For example, you cannot [static-batch](https://docs.unity3d.com/Manual/DrawCallBatching.html) GameObjects that have an animation based on the object pivot, but the GPU can instance them.  |
| **Add Precomputed Velocity** | Enable the checkbox to use precomputed velocity information stored in an Alembic file. |
