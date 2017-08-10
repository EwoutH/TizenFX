// Copyright (c) 2017 Samsung Electronics Co., Ltd.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
//
// This File has been auto-generated by SWIG and then modified using DALi Ruby Scripts
// Some have been manually changed

namespace Tizen.NUI.UIComponents
{

    using System;
    using System.Runtime.InteropServices;
    using Tizen.NUI.BaseComponents;

    /// <summary>
    /// Button is a base class for different kinds of buttons.<br>
    /// This class provides the disabled property and the clicked signal.<br>
    /// A Clicked event handler is emitted when the button is touched and the touch point doesn't leave the boundary of the button.<br>
    /// When the disabled property is set to true, no signal is emitted.<br>
    /// 'Visual' describes not just traditional images like png, bmp but refers to whatever is used to show the button, it could be a color, gradient or some other kind of renderer.<br>
    /// The button's appearance can be modified by setting properties for the various visuals/images.<br>
    /// It is not mandatory to set all visuals. A button could be defined only by setting its background visual or by setting its background and selected visuals.<br>
    /// The button visual is shown over the background visual.<br>
    /// When pressed the unselected visuals are replaced by the selected visual.<br>
    /// The text label is always placed on the top of all images.<br>
    /// When the button is disabled, background, button and selected visuals are replaced by their disabled visuals.<br>
    /// </summary>
    public class Button : View
    {
        private global::System.Runtime.InteropServices.HandleRef swigCPtr;

        internal Button(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NDalicPINVOKE.Button_SWIGUpcast(cPtr), cMemoryOwn)
        {
            swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
        }

        internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Button obj)
        {
            return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
        }

        /// <summary>
        /// To make Button instance be disposed.
        /// </summary>
        protected override void Dispose(DisposeTypes type)
        {
            if (disposed)
            {
                return;
            }

            if (type == DisposeTypes.Explicit)
            {
                //Called by User
                //Release your own managed resources here.
                //You should release all of your own disposable objects here.

            }

            //Release your own unmanaged resources here.
            //You should not access any managed member here except static instance.
            //because the execution order of Finalizes is non-deterministic.

            if (swigCPtr.Handle != global::System.IntPtr.Zero)
            {
                if (swigCMemOwn)
                {
                    swigCMemOwn = false;
                    NDalicPINVOKE.delete_Button(swigCPtr);
                }
                swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
            }

            base.Dispose(type);
        }


        private EventHandlerWithReturnType<object, EventArgs, bool> _clickedEventHandler;
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool ClickedCallbackType(global::System.IntPtr data);
        private ClickedCallbackType _clickedCallback;

        /// <summary>
        /// Clicked will be triggered when the button is touched and the touch point doesn't leave the boundary of the button.
        /// </summary>
        public event EventHandlerWithReturnType<object, EventArgs, bool> Clicked
        {
            add
            {
                if (_clickedEventHandler == null)
                {
                    _clickedCallback = OnClicked;
                    ClickedSignal().Connect(_clickedCallback);
                }

                _clickedEventHandler += value;
            }

            remove
            {
                _clickedEventHandler -= value;

                if (_clickedEventHandler == null && ClickedSignal().Empty() == false)
                {
                    ClickedSignal().Disconnect(_clickedCallback);
                }
            }
        }


        private bool OnClicked(IntPtr data)
        {
            if (_clickedEventHandler != null)
            {
                return _clickedEventHandler(this, null);
            }
            return false;
        }



        private EventHandlerWithReturnType<object, EventArgs, bool> _pressedEventHandler;
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool PressedCallbackType(global::System.IntPtr data);
        private PressedCallbackType _pressedCallback;

        /// <summary>
        /// Pressed will be triggered when the button is touched.
        /// </summary>
        public event EventHandlerWithReturnType<object, EventArgs, bool> Pressed
        {
            add
            {
                if (_pressedEventHandler == null)
                {
                    _pressedCallback = OnPressed;
                    PressedSignal().Connect(_pressedCallback);
                }

                _pressedEventHandler += value;
            }

            remove
            {
                _pressedEventHandler -= value;

                if (_pressedEventHandler == null && PressedSignal().Empty() == false)
                {
                    this.PressedSignal().Disconnect(_pressedCallback);
                }
            }
        }

        private bool OnPressed(IntPtr data)
        {
            if (_pressedEventHandler != null)
            {
                return _pressedEventHandler(this, null);
            }
            return false;
        }



        private EventHandlerWithReturnType<object, EventArgs, bool> _releasedEventHandler;
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool ReleasedCallbackType(global::System.IntPtr data);
        private ReleasedCallbackType _releasedCallback;

        /// <summary>
        /// Released will be triggered when the button is touched and the touch point leaves the boundary of the button.
        /// </summary>
        public event EventHandlerWithReturnType<object, EventArgs, bool> Released
        {
            add
            {
                if (_releasedEventHandler == null)
                {
                    _releasedCallback = OnReleased;
                    ReleasedSignal().Connect(_releasedCallback);
                }
                _releasedEventHandler += value;
            }

            remove
            {
                _releasedEventHandler -= value;

                if (_releasedEventHandler == null && ReleasedSignal().Empty() == false)
                {
                    ReleasedSignal().Disconnect(_releasedCallback);
                }

            }
        }

        private bool OnReleased(IntPtr data)
        {
            if (_releasedEventHandler != null)
            {
                return _releasedEventHandler(this, null);
            }
            return false;
        }


        private EventHandlerWithReturnType<object, EventArgs, bool> _stateChangedEventHandler;
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate bool StateChangedCallback(global::System.IntPtr data);
        private StateChangedCallback _stateChangedCallback;

        /// <summary>
        /// StateChanged will be triggered when the button's state is changed.
        /// </summary>
        public event EventHandlerWithReturnType<object, EventArgs, bool> StateChanged
        {
            add
            {
                if (_stateChangedEventHandler == null)
                {
                    _stateChangedCallback = OnStateChanged;
                    StateChangedSignal().Connect(_stateChangedCallback);
                }

                _stateChangedEventHandler += value;
            }

            remove
            {
                _stateChangedEventHandler -= value;

                if (_stateChangedEventHandler == null && StateChangedSignal().Empty() == false)
                {
                    StateChangedSignal().Disconnect(_stateChangedCallback);
                }
            }
        }

        private bool OnStateChanged(IntPtr data)
        {
            if (_stateChangedEventHandler != null)
            {
                return _stateChangedEventHandler(this, null);
            }
            return false;
        }


        /// <summary>
        /// Gets/Sets the unselected button foreground/icon visual
        /// </summary>
        public Tizen.NUI.PropertyMap UnselectedVisual
        {
            get
            {
                Tizen.NUI.PropertyMap temp = new Tizen.NUI.PropertyMap();
                GetProperty(Button.Property.UNSELECTED_VISUAL).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(Button.Property.UNSELECTED_VISUAL, new Tizen.NUI.PropertyValue(value));
            }
        }

        /// <summary>
        /// Gets/Sets the selected button foreground/icon visual
        /// </summary>
        public Tizen.NUI.PropertyMap SelectedVisual
        {
            get
            {
                Tizen.NUI.PropertyMap temp = new Tizen.NUI.PropertyMap();
                GetProperty(Button.Property.SELECTED_VISUAL).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(Button.Property.SELECTED_VISUAL, new Tizen.NUI.PropertyValue(value));
            }
        }

        /// <summary>
        /// Gets/Sets the disabled selected state foreground/icon button visual
        /// </summary>
        public Tizen.NUI.PropertyMap DisabledSelectedVisual
        {
            get
            {
                Tizen.NUI.PropertyMap temp = new Tizen.NUI.PropertyMap();
                GetProperty(Button.Property.DISABLED_SELECTED_VISUAL).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(Button.Property.DISABLED_SELECTED_VISUAL, new Tizen.NUI.PropertyValue(value));
            }
        }

        /// <summary>
        /// Gets/Sets the disabled unselected state foreground/icon visual
        /// </summary>
        public Tizen.NUI.PropertyMap DisabledUnselectedVisual
        {
            get
            {
                Tizen.NUI.PropertyMap temp = new Tizen.NUI.PropertyMap();
                GetProperty(Button.Property.DISABLED_UNSELECTED_VISUAL).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(Button.Property.DISABLED_UNSELECTED_VISUAL, new Tizen.NUI.PropertyValue(value));
            }
        }

        /// <summary>
        /// Gets/Sets the disabled in the unselected state background, button visual
        /// </summary>
        public Tizen.NUI.PropertyMap UnselectedBackgroundVisual
        {
            get
            {
                Tizen.NUI.PropertyMap temp = new Tizen.NUI.PropertyMap();
                GetProperty(Button.Property.UNSELECTED_BACKGROUND_VISUAL).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(Button.Property.UNSELECTED_BACKGROUND_VISUAL, new Tizen.NUI.PropertyValue(value));
            }
        }

        /// <summary>
        /// Gets/Sets the selected background button visual
        /// </summary>
        public Tizen.NUI.PropertyMap SelectedBackgroundVisual
        {
            get
            {
                Tizen.NUI.PropertyMap temp = new Tizen.NUI.PropertyMap();
                GetProperty(Button.Property.SELECTED_BACKGROUND_VISUAL).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(Button.Property.SELECTED_BACKGROUND_VISUAL, new Tizen.NUI.PropertyValue(value));
            }
        }

        /// <summary>
        /// Gets/Sets the disabled while unselected background button visual
        /// </summary>
        public Tizen.NUI.PropertyMap DisabledUnselectedBackgroundVisual
        {
            get
            {
                Tizen.NUI.PropertyMap temp = new Tizen.NUI.PropertyMap();
                GetProperty(Button.Property.DISABLED_UNSELECTED_BACKGROUND_VISUAL).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(Button.Property.DISABLED_UNSELECTED_BACKGROUND_VISUAL, new Tizen.NUI.PropertyValue(value));
            }
        }

        /// <summary>
        /// Gets/Sets the disabled while selected background button visual
        /// </summary>
        public Tizen.NUI.PropertyMap DisabledSelectedBackgroundVisual
        {
            get
            {
                Tizen.NUI.PropertyMap temp = new Tizen.NUI.PropertyMap();
                GetProperty(Button.Property.DISABLED_SELECTED_BACKGROUND_VISUAL).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(Button.Property.DISABLED_SELECTED_BACKGROUND_VISUAL, new Tizen.NUI.PropertyValue(value));
            }
        }

        /// <summary>
        /// Gets/Sets the position of the the label in relation to the foreground/icon if both present
        /// </summary>
        public Align LabelRelativeAlignment
        {
            get
            {
                string temp;
                if (GetProperty(Button.Property.LABEL_RELATIVE_ALIGNMENT).Get(out temp) == false)
                {
                    NUILog.Error("LabelRelativeAlignment get error!");
                }
                switch (temp)
                {
                    case "BEGIN":
                        return Align.Begin;
                    case "END":
                        return Align.End;
                    case "TOP":
                        return Align.Top;
                    case "BOTTOM":
                        return Align.Bottom;
                    default:
                        return Align.End;
                }
            }
            set
            {
                string valueToString = "";
                switch (value)
                {
                    case Align.Begin:
                    {
                        valueToString = "BEGIN";
                        break;
                    }
                    case Align.End:
                    {
                        valueToString = "END";
                        break;
                    }
                    case Align.Top:
                    {
                        valueToString = "TOP";
                        break;
                    }
                    case Align.Bottom:
                    {
                        valueToString = "BOTTOM";
                        break;
                    }
                    default:
                    {
                        valueToString = "END";
                        break;
                    }
                }
                SetProperty(Button.Property.LABEL_RELATIVE_ALIGNMENT, new Tizen.NUI.PropertyValue(valueToString));
            }
        }

        /// <summary>
        /// Gets/Sets the padding around the text
        /// </summary>
        public Vector4 LabelPadding
        {
            get
            {
                Vector4 temp = new Vector4(0.0f, 0.0f, 0.0f, 0.0f);
                GetProperty(Button.Property.LABEL_PADDING).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(Button.Property.LABEL_PADDING, new Tizen.NUI.PropertyValue(value));
            }
        }

        /// <summary>
        /// Gets/Sets the padding around the foreground visual
        /// </summary>
        public Vector4 ForegroundVisualPadding
        {
            get
            {
                Vector4 temp = new Vector4(0.0f, 0.0f, 0.0f, 0.0f);
                GetProperty(Button.Property.FOREGROUND_VISUAL_PADDING).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(Button.Property.FOREGROUND_VISUAL_PADDING, new Tizen.NUI.PropertyValue(value));
            }
        }

        internal class Property
        {
            internal static readonly int UNSELECTED_VISUAL = NDalicManualPINVOKE.Button_Property_UNSELECTED_VISUAL_get();
            internal static readonly int SELECTED_VISUAL = NDalicManualPINVOKE.Button_Property_SELECTED_VISUAL_get();
            internal static readonly int DISABLED_SELECTED_VISUAL = NDalicManualPINVOKE.Button_Property_DISABLED_SELECTED_VISUAL_get();
            internal static readonly int DISABLED_UNSELECTED_VISUAL = NDalicManualPINVOKE.Button_Property_DISABLED_UNSELECTED_VISUAL_get();
            internal static readonly int UNSELECTED_BACKGROUND_VISUAL = NDalicManualPINVOKE.Button_Property_UNSELECTED_BACKGROUND_VISUAL_get();
            internal static readonly int SELECTED_BACKGROUND_VISUAL = NDalicManualPINVOKE.Button_Property_SELECTED_BACKGROUND_VISUAL_get();
            internal static readonly int DISABLED_UNSELECTED_BACKGROUND_VISUAL = NDalicManualPINVOKE.Button_Property_DISABLED_UNSELECTED_BACKGROUND_VISUAL_get();
            internal static readonly int DISABLED_SELECTED_BACKGROUND_VISUAL = NDalicManualPINVOKE.Button_Property_DISABLED_SELECTED_BACKGROUND_VISUAL_get();
            internal static readonly int LABEL_RELATIVE_ALIGNMENT = NDalicManualPINVOKE.Button_Property_LABEL_RELATIVE_ALIGNMENT_get();
            internal static readonly int LABEL_PADDING = NDalicManualPINVOKE.Button_Property_LABEL_PADDING_get();
            internal static readonly int FOREGROUND_VISUAL_PADDING = NDalicManualPINVOKE.Button_Property_VISUAL_PADDING_get();
            internal static readonly int AUTO_REPEATING = NDalicPINVOKE.Button_Property_AUTO_REPEATING_get();
            internal static readonly int INITIAL_AUTO_REPEATING_DELAY = NDalicPINVOKE.Button_Property_INITIAL_AUTO_REPEATING_DELAY_get();
            internal static readonly int NEXT_AUTO_REPEATING_DELAY = NDalicPINVOKE.Button_Property_NEXT_AUTO_REPEATING_DELAY_get();
            internal static readonly int TOGGLABLE = NDalicPINVOKE.Button_Property_TOGGLABLE_get();
            internal static readonly int SELECTED = NDalicPINVOKE.Button_Property_SELECTED_get();
            internal static readonly int UNSELECTED_COLOR = NDalicPINVOKE.Button_Property_UNSELECTED_COLOR_get();
            internal static readonly int SELECTED_COLOR = NDalicPINVOKE.Button_Property_SELECTED_COLOR_get();
            internal static readonly int LABEL = NDalicPINVOKE.Button_Property_LABEL_get();
        }

        /// <summary>
        /// Creates an uninitialized Button.<br>
        /// Only derived versions can be instantiated.<br>
        /// </summary>
        public Button() : this(NDalicPINVOKE.new_Button__SWIG_0(), true)
        {
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
        }

        internal ButtonSignal PressedSignal()
        {
            ButtonSignal ret = new ButtonSignal(NDalicPINVOKE.Button_PressedSignal(swigCPtr), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal ButtonSignal ReleasedSignal()
        {
            ButtonSignal ret = new ButtonSignal(NDalicPINVOKE.Button_ReleasedSignal(swigCPtr), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal ButtonSignal ClickedSignal()
        {
            ButtonSignal ret = new ButtonSignal(NDalicPINVOKE.Button_ClickedSignal(swigCPtr), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        internal ButtonSignal StateChangedSignal()
        {
            ButtonSignal ret = new ButtonSignal(NDalicPINVOKE.Button_StateChangedSignal(swigCPtr), false);
            if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
            return ret;
        }

        /// <summary>
        /// If the autorepeating property is set to true then the togglable property is set to false.
        /// </summary>
        public bool AutoRepeating
        {
            get
            {
                bool temp = false;
                GetProperty(Button.Property.AUTO_REPEATING).Get(out temp);
                return temp;
            }
            set
            {
                SetProperty(Button.Property.AUTO_REPEATING, new Tizen.NUI.PropertyValue(value));
            }
        }

        /// <summary>
        /// By default this value is set to 0.15 seconds.
        /// </summary>
        public float InitialAutoRepeatingDelay
        {
            get
            {
                float temp = 0.0f;
                GetProperty(Button.Property.INITIAL_AUTO_REPEATING_DELAY).Get(out temp);
                return temp;
            }
            set
            {
                SetProperty(Button.Property.INITIAL_AUTO_REPEATING_DELAY, new Tizen.NUI.PropertyValue(value));
            }
        }

        /// <summary>
        /// default this value is set to 0.05 seconds.
        /// </summary>
        public float NextAutoRepeatingDelay
        {
            get
            {
                float temp = 0.0f;
                GetProperty(Button.Property.NEXT_AUTO_REPEATING_DELAY).Get(out temp);
                return temp;
            }
            set
            {
                SetProperty(Button.Property.NEXT_AUTO_REPEATING_DELAY, new Tizen.NUI.PropertyValue(value));
            }
        }

        /// <summary>
        /// If the togglable property is set to true, then the autorepeating property is set to false.
        /// </summary>
        public bool Togglable
        {
            get
            {
                bool temp = false;
                GetProperty(Button.Property.TOGGLABLE).Get(out temp);
                return temp;
            }
            set
            {
                SetProperty(Button.Property.TOGGLABLE, new Tizen.NUI.PropertyValue(value));
            }
        }

        /// <summary>
        /// /Gets/Sets the togglable button as either selected or unselected, togglable property must be set to true.
        /// </summary>
        public bool Selected
        {
            get
            {
                bool temp = false;
                GetProperty(Button.Property.SELECTED).Get(out temp);
                return temp;
            }
            set
            {
                SetProperty(Button.Property.SELECTED, new Tizen.NUI.PropertyValue(value));
            }
        }

        /// <summary>
        /// Gets/Sets unselected color.
        /// </summary>
        public Color UnselectedColor
        {
            get
            {
                Color temp = new Color(0.0f, 0.0f, 0.0f, 0.0f);
                GetProperty(Button.Property.UNSELECTED_COLOR).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(Button.Property.UNSELECTED_COLOR, new Tizen.NUI.PropertyValue(value));
            }
        }

        /// <summary>
        /// Gets/Sets selected color.
        /// </summary>
        public Color SelectedColor
        {
            get
            {
                Color temp = new Color(0.0f, 0.0f, 0.0f, 0.0f);
                GetProperty(Button.Property.SELECTED_COLOR).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(Button.Property.SELECTED_COLOR, new Tizen.NUI.PropertyValue(value));
            }
        }

        /// <summary>
        /// Gets/Sets label.
        /// </summary>
        public Tizen.NUI.PropertyMap Label
        {
            get
            {
                Tizen.NUI.PropertyMap temp = new Tizen.NUI.PropertyMap();
                GetProperty(Button.Property.LABEL).Get(temp);
                return temp;
            }
            set
            {
                SetProperty(Button.Property.LABEL, new Tizen.NUI.PropertyValue(value));
            }
        }

        /// <summary>
        /// Gets/Sets text of label.
        /// </summary>
        public string LabelText
        {
            get
            {
                Tizen.NUI.PropertyMap map = new Tizen.NUI.PropertyMap();
                GetProperty( Button.Property.LABEL).Get(map);
                Tizen.NUI.PropertyValue value = map.Find( TextVisualProperty.Text, "Text");
                string str;
                value.Get(out str);
                return str;
            }
            set
            {
                SetProperty( Button.Property.LABEL, new Tizen.NUI.PropertyValue( value ) );
            }
        }

        /// <summary>
        /// Enumeration for describing the position the text label can be in relation to the control(and foreground/icon).
        /// </summary>
        public enum Align
        {
            /// <summary>
            /// At the start of the control before the foreground/icon
            /// </summary>
            Begin,
            /// <summary>
            /// At the end of the control after the foreground/icon
            /// </summary>
            End,
            /// <summary>
            /// At the top of the control above the foreground/icon
            /// </summary>
            Top,
            /// <summary>
            /// At the bottom of the control below the foreground/icon
            /// </summary>
            Bottom
        }

    }

}