﻿using Prism.Events;
using System;
using Windows.Devices.Input;

namespace Prism.Windows.AppModel
{
    /// <summary>
    /// 
    /// </summary>
    public interface IDeviceGestureService
    {
        /// <summary>
        /// Returns true if device hardware back button is present.
        /// </summary>
        bool IsHardwareBackButtonPresent { get; }

        /// <summary>
        /// Returns true if device camera button is present.
        /// </summary>
        bool IsHardwareCameraButtonPresent { get; }

        /// <summary>
        /// Returns true if keyboard is attached to device
        /// </summary>
        bool IsKeyboardPresent { get; }

        /// <summary>
        /// Returns true if mouse is attached to device
        /// </summary>
        bool IsMousePresent { get; }

        /// <summary>
        /// Returns true if device accepts touch input
        /// </summary>
        bool IsTouchPresent { get; }

        /// <summary>
        /// Enables automatic handling of the title bar back button.
        /// </summary>
        /// <param name="eventAggregator">The event aggregator that is publishing the Prism framework's NavigationStateChangedEvents</param>
        void EnableTitleBarBackButton(IEventAggregator eventAggregator);

        /// <summary>
        /// Disables automatic handling of the window chrome back buton.
        /// </summary>
        void DisableTitleBarBackButton();

        /// <summary>
        /// Raised when a navigation go back event occurs
        /// </summary>
        event EventHandler<DeviceGestureEventArgs> GoBackRequested;

        /// <summary>
        /// Raised when a navigation go forward event occurs
        /// </summary>
        event EventHandler<DeviceGestureEventArgs> GoForwardRequested;

        /// <summary>
        /// Raised when camera button is half pressed
        /// </summary>
        event EventHandler<DeviceGestureEventArgs> CameraButtonHalfPressed;

        /// <summary>
        /// Raised when camera button is fully pressed
        /// </summary>
        event EventHandler<DeviceGestureEventArgs> CameraButtonPressed;

        /// <summary>
        /// Raised when camera button is released
        /// </summary>
        event EventHandler<DeviceGestureEventArgs> CameraButtonReleased;

        /// <summary>
        /// Raised on mouse move
        /// </summary>
        event EventHandler<MouseEventArgs> MouseMoved;

    }
}
