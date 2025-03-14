// Unity C# reference source
// Copyright (c) Unity Technologies. For terms of use, see
// https://unity3d.com/legal/licenses/Unity_Reference_Only_License

using System;

namespace UnityEngine.UIElements
{
    /// <summary>
    /// This interface describes the data used by keyboard events.
    /// </summary>
    /// <remarks>
    /// Refer to the [[wiki:UIE-Keyboard-Events|Keyboard events]] manual page for more information and examples.
    /// </remarks>
    /// <seealso cref="KeyDownEvent"/>
    /// <seealso cref="KeyUpEvent"/>
    public interface IKeyboardEvent
    {
        /// <summary>
        /// Gets flags that indicate whether modifier keys (Alt, Ctrl, Shift, Windows/Cmd) are pressed.
        /// </summary>
        /// <remarks>
        /// See <see cref="EventModifiers"/> for more information.
        /// </remarks>
        EventModifiers modifiers { get; }

        /// <summary>
        /// Gets the character entered.
        /// </summary>
        /// <remarks>
        /// This is the character entered when a key is pressed, taking into account the current keyboard layout. For example,
        /// pressing the "A" key causes this property to return either "a" or "A", depending on whether the Shift
        /// key is pressed at the time. The Shift key itself does not produce a character. When  pressed, it returns
        /// an empty string.
        /// </remarks>
        char character { get; }

        /// <summary>
        /// The key code.
        /// </summary>
        /// <remarks>
        /// This is the code of the physical key that was pressed. It doesn't take into account the keyboard
        /// layout, and it displays modifier keys, since a key was pressed. For example, pressing the "A" key
        /// will cause this property to return KeyCode.A regardless of whether the Shift key is pressed or not.
        /// The Shift key itself returns KeyCode.LeftShift since it is a physical key on the keyboard.
        /// </remarks>
        KeyCode keyCode { get; }

        /// <summary>
        /// Gets a boolean value that indicates whether the Shift key is pressed.
        /// </summary>
        /// <remarks>
        /// See <see cref="EventModifiers.Shift"/> for more information.
        /// </remarks>
        bool shiftKey { get; }

        /// <summary>
        /// Gets a boolean value that indicates whether the Ctrl key is pressed.
        /// </summary>
        /// <remarks>
        /// Refer to <see cref="EventModifiers.Control"/> for more information.
        /// </remarks>
        bool ctrlKey { get; }

        /// <summary>
        /// Gets a boolean value that indicates whether the Windows/Cmd key is pressed.
        /// </summary>
        /// <remarks>
        /// Refer to <see cref="EventModifiers.Command"/> for more information.
        /// </remarks>
        bool commandKey { get; }

        /// <summary>
        /// Gets a boolean value that indicates whether the Alt key is pressed.
        /// </summary>
        /// <remarks>
        /// Refer to <see cref="EventModifiers.Alt"/> for more information.
        /// </remarks>
        bool altKey { get; }

        /// <summary>
        /// Gets a boolean value that indicates whether the platform-specific action key is pressed.
        /// </summary>
        /// <remarks>
        /// The platform-specific action key is Cmd on macOs, and Ctrl on all other platforms.
        /// </remarks>
        bool actionKey { get; }
    }

    /// <summary>
    /// This is the base class for keyboard events.
    /// </summary>
    /// <remarks>
    /// The typical keyboard event loop is as follows:
    ///   - When a key is pressed, a <see cref="KeyDownEvent"/> is sent.
    ///   - If the key is held down for a duration determined by the OS, another KeyDownEvent with the same data is
    ///     sent. While the key is held down, the event is sent repeatedly at a frequency determined by the OS.
    ///   - When the key is released, a <see cref="KeyUpEvent"/> is sent.
    ///
    /// By default, keyboard events trickle down and bubble up. disabled elements won't receive these events.
    ///
    /// Refer to the [[wiki:UIE-Keyboard-Events|Keyboard events]] manual page for more information and examples.
    /// </remarks>
    /// <seealso cref="KeyDownEvent"/>
    /// <seealso cref="KeyUpEvent"/>
    [EventCategory(EventCategory.Keyboard)]
    public abstract class KeyboardEventBase<T> : EventBase<T>, IKeyboardEvent where T : KeyboardEventBase<T>, new()
    {
        /// <summary>
        /// Gets flags that indicate whether modifier keys (Alt, Ctrl, Shift, Windows/Cmd) are pressed.
        /// </summary>
        public EventModifiers modifiers { get; protected set; }
        /// <summary>
        /// Gets the character entered.
        /// </summary>
        /// <remarks>
        /// This is the character entered when a key is pressed, taking into account the current keyboard layout. For example,
        /// pressing the "A" key causes this property to return either "a" or "A", depending on whether the Shift
        /// key is pressed at the time. The Shift key itself does not produce a character. When  pressed, it returns
        /// an empty string.
        /// </remarks>
        public char character { get; protected set; }
        /// <summary>
        /// The key code.
        /// </summary>
        /// <remarks>
        /// This is the code of the physical key that was pressed. It doesn't take into account the keyboard
        /// layout, and it displays modifier keys, since a key was pressed. For example, pressing the "A" key
        /// will cause this property to return KeyCode.A regardless of whether the Shift key is pressed or not.
        /// The Shift key itself returns KeyCode.LeftShift since it is a physical key on the keyboard.
        /// </remarks>
        public KeyCode keyCode { get; protected set; }

        /// <summary>
        /// Gets a boolean value that indicates whether the Shift key is pressed.
        /// </summary>
        /// <remarks>
        /// See <see cref="EventModifiers.Shift"/> for more information.
        /// </remarks>
        public bool shiftKey
        {
            get { return (modifiers & EventModifiers.Shift) != 0; }
        }

        /// <summary>
        /// Gets a boolean value that indicates whether the Ctrl key is pressed.
        /// </summary>
        /// <remarks>
        /// See <see cref="EventModifiers.Control"/> for more information.
        /// </remarks>
        public bool ctrlKey
        {
            get { return (modifiers & EventModifiers.Control) != 0; }
        }

        /// <summary>
        /// Gets a boolean value that indicates whether the Windows/Cmd key is pressed.
        /// </summary>
        /// <remarks>
        /// Refer to <see cref="EventModifiers.Command"/> for more information.
        /// </remarks>
        public bool commandKey
        {
            get { return (modifiers & EventModifiers.Command) != 0; }
        }

        /// <summary>
        /// Gets a boolean value that indicates whether the Alt key is pressed.
        /// </summary>
        /// <remarks>
        /// Refer to <see cref="EventModifiers.Alt"/> for more information.
        /// </remarks>
        public bool altKey
        {
            get { return (modifiers & EventModifiers.Alt) != 0; }
        }

        /// <summary>
        /// Gets a boolean value that indicates whether the Function key is pressed.
        /// </summary>
        /// <remarks>
        /// Refer to <see cref="EventModifiers.FunctionKey"/> for more information.
        /// </remarks>
        internal bool functionKey
        {
            get { return (modifiers & EventModifiers.FunctionKey) != 0; }
        }

        /// <summary>
        /// Gets a boolean value that indicates whether the platform-specific action key is pressed.
        /// </summary>
        /// <remarks>
        /// The platform-specific action key is Cmd on macOS, and Ctrl on all other platforms.
        /// </remarks>
        public bool actionKey
        {
            get
            {
                if (Application.platform == RuntimePlatform.OSXEditor || Application.platform == RuntimePlatform.OSXPlayer)
                {
                    return commandKey;
                }
                else
                {
                    return ctrlKey;
                }
            }
        }

        // FIXME: see https://www.w3.org/TR/DOM-Level-3-Events/#interface-keyboardevent for key, code and location values.
        /// <summary>
        /// Resets the event members to their initial values.
        /// </summary>
        protected override void Init()
        {
            base.Init();
            LocalInit();
        }

        void LocalInit()
        {
            propagation = EventPropagation.Bubbles | EventPropagation.TricklesDown |
                EventPropagation.SkipDisabledElements;
            modifiers = default(EventModifiers);
            character = default(char);
            keyCode = default(KeyCode);
        }

        /// <summary>
        /// Gets a keyboard event from the event pool and initializes it with the given values. Use this function
        /// instead of creating new events. Events obtained using this method need to be released back to the pool.
        /// You can use `Dispose()` to release them.
        /// </summary>
        /// <param name="c">The character for this event.</param>
        /// <param name="keyCode">The key code for this event.</param>
        /// <param name="modifiers">Event modifier keys that are active for this event.</param>
        /// <returns>An initialized event.</returns>
        public static T GetPooled(char c, KeyCode keyCode, EventModifiers modifiers)
        {
            T e = GetPooled();
            e.modifiers = modifiers;
            e.character = c;
            e.keyCode = keyCode;
            return e;
        }

        /// <summary>
        /// Gets a keyboard event from the event pool and initializes it with the given values. Use this
        /// function instead of creating new events. Events obtained using this method need to be released
        /// back to the pool. You can use `Dispose()` to release them.
        /// </summary>
        /// <param name="systemEvent">A keyboard IMGUI event.</param>
        /// <returns>An initialized event.</returns>
        public static T GetPooled(Event systemEvent)
        {
            T e = GetPooled();
            e.imguiEvent = systemEvent;
            if (systemEvent != null)
            {
                e.modifiers = systemEvent.modifiers;
                e.character = systemEvent.character;
                e.keyCode = systemEvent.keyCode;
            }
            return e;
        }

        internal override void Dispatch(BaseVisualElementPanel panel)
        {
            EventDispatchUtilities.DispatchToFocusedElementOrPanelRoot(this, panel);
        }

        protected KeyboardEventBase()
        {
            LocalInit();
        }
    }

    /// <summary>
    /// This event is sent when a key is pressed.
    /// </summary>
    /// <remarks>
    /// This event trickles down and bubbles up.
    /// </remarks>
    public class KeyDownEvent : KeyboardEventBase<KeyDownEvent>
    {
        static KeyDownEvent()
        {
            SetCreateFunction(() => new KeyDownEvent());
        }

        // This is needed for TextEditor features that require an imguiEvent but receive non-imgui events
        internal void GetEquivalentImguiEvent(Event outImguiEvent)
        {
            if (imguiEvent != null)
            {
                outImguiEvent.CopyFrom(imguiEvent);
            }
            else
            {
                outImguiEvent.type = EventType.KeyDown;
                outImguiEvent.modifiers = modifiers;
                outImguiEvent.character = character;
                outImguiEvent.keyCode = keyCode;
            }
        }

        protected internal override void PostDispatch(IPanel panel)
        {
            base.PostDispatch(panel);

            // Only editor panels send navigation events automatically. This is because runtime panels may have an
            // abstract input layer where navigation events can be triggered by various different input combinations.
            // Note that by convention, stopping the KeyDownEvent will not stop resulting navigation events, but using
            // the IMGUI Event will, because IMGUI has no other way of stopping the navigation events.
            if (panel.contextType == ContextType.Editor && !(imguiEvent?.type == EventType.Used))
            {
                SendEquivalentNavigationEventIfAny(panel);
            }
        }

        private void SendEquivalentNavigationEventIfAny(IPanel panel)
        {
            if (character == '\n' || character == 3 || character == 10 || character == ' ')
            {
                using (var ne = NavigationSubmitEvent.GetPooled(NavigationDeviceType.Keyboard, modifiers))
                {
                    ne.elementTarget = elementTarget;
                    panel.visualTree.SendEvent(ne);
                }
            }
            else if (keyCode == KeyCode.Escape)
            {
                using (var ne = NavigationCancelEvent.GetPooled(NavigationDeviceType.Keyboard, modifiers))
                {
                    ne.elementTarget = elementTarget;
                    panel.visualTree.SendEvent(ne);
                }
            }
            else if (this.ShouldSendNavigationMoveEvent())
            {
                using (var ne = NavigationMoveEvent.GetPooled(
                    shiftKey ? NavigationMoveEvent.Direction.Previous : NavigationMoveEvent.Direction.Next,
                    NavigationDeviceType.Keyboard, modifiers))
                {
                    ne.elementTarget = elementTarget;
                    panel.visualTree.SendEvent(ne);
                }
            }
            else if (keyCode == KeyCode.RightArrow || keyCode == KeyCode.LeftArrow ||
                     keyCode == KeyCode.UpArrow || keyCode == KeyCode.DownArrow)
            {
                var d = keyCode == KeyCode.RightArrow ? Vector2.right :
                    keyCode == KeyCode.LeftArrow ? Vector2.left :
                    keyCode == KeyCode.UpArrow ? Vector2.up :
                    Vector2.down;
                using (var ne = NavigationMoveEvent.GetPooled(d, NavigationDeviceType.Keyboard, modifiers))
                {
                    ne.elementTarget = elementTarget;
                    panel.visualTree.SendEvent(ne);
                }
            }
        }

    }

    internal static class KeyboardEventExtensions
    {
        internal static bool ShouldSendNavigationMoveEvent(this KeyDownEvent e)
        {
            // We must rely on KeyCode.Tab as Shift+Tab on Mac doesn't send the \t character. It sends char(25) instead.
            // On linux Platform shift+tab event does contain both key code and character=='\t'
            return e.keyCode == KeyCode.Tab && !e.ctrlKey && !e.altKey && !e.commandKey && !e.functionKey;
        }

        internal static bool ShouldSendNavigationMoveEventRuntime(this Event e)
        {
            // We must rely on KeyCode.Tab as Shift+Tab on Mac doesn't send the \t character. It sends char(25) instead.
            return e.type == EventType.KeyDown && e.keyCode == KeyCode.Tab;
        }
    }

    /// <summary>
    /// This event is sent when a pressed key is released.
    /// </summary>
    /// <remarks>
    /// This event trickles down and bubbles up.
    /// </remarks>
    public class KeyUpEvent : KeyboardEventBase<KeyUpEvent>
    {
        static KeyUpEvent()
        {
            SetCreateFunction(() => new KeyUpEvent());
        }
    }
}
