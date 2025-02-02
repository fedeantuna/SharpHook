namespace SharpHook.Providers;

/// <summary>
/// Represents a provider of low-level global hook functionality.
/// </summary>
/// <seealso cref="UioHookProvider" />
public interface IGlobalHookProvider
{
    /// <summary>
    /// Sets the hook callback function.
    /// </summary>
    /// <param name="dispatchProc">
    /// The function to call when an event is raised, or <see langword="null" /> to unset the function.
    /// </param>
    /// <param name="userData">
    /// Custom data to pass to the callback. Should not be used, and <see cref="IntPtr.Zero" /> should always be passed.
    /// </param>
    /// <seealso cref="DispatchProc" />
    void SetDispatchProc(DispatchProc? dispatchProc, IntPtr userData);

    /// <summary>
    /// Runs the global hook and blocks the thread until it's stopped.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    UioHookResult Run();

    /// <summary>
    /// Stops the global hook.
    /// </summary>
    /// <returns>The result of the operation.</returns>
    UioHookResult Stop();
}
