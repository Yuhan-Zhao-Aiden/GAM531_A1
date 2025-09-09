using System;
using OpenTK;
using OpenTK.Mathematics;
using OpenTK.Windowing.Desktop;
using OpenTK.Graphics.OpenGL;
using OpenTK.Windowing.Common;

namespace FirstEngine
{
  public class Game : GameWindow
  {
    private int vbo;
    private int vao;
    private int shaderProgramHandle;
    private static NativeWindowSettings native = new()
    {
      Title = "My First Render",
      APIVersion = new Version(3, 3),
      Profile = ContextProfile.Core
    };

    public Game()
    : base(GameWindowSettings.Default, native)
    {
      this.Size = new Vector2i(1280, 720);
      this.CenterWindow(this.Size);
    }

    protected override void OnLoad()
    {
      base.OnLoad();
      GL.ClearColor(new Color4(0.2f, 0.6f, 0.7f, 1f));

      // GL viewport size
      
    }
  }
}