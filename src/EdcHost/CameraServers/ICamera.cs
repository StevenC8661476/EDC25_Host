namespace EdcHost.CameraServers;

public interface ICamera : IDisposable
{
    int CameraIndex { get; }
    int Height { get; }
    bool IsOpened { get; }
    byte[]? JpegData { get; }
    int Width { get; }
    Tuple<float, float>? TargetPosition { get; }
    Tuple<float, float>? TargetPositionNotCalibrated { get; }

    void Close();
    void Open();
}
