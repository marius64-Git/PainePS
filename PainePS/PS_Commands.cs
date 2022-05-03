using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PainePS
{
    public static class PS_Commands
    {
        //5.1.1 Level 0 – Operating Commands
        public const int START_OUT = 1; //Start continuous data output.
        public const int STOP_OUT = 2; //Stop continuous data output.
        public const int POLL_DATA = 3; //Request next output data block (pressure & temperature).
        public const int READ_LAST_PRESSURE = 5; //Returns the last reported pressure value.
        public const int READ_TEMPERATURE = 6; //Returns the current temperature.
        public const int READ_VERSION = 9; //Returns the software version number and other part info.
        public const int ENTER_SETUP_MODE = 60; //Put transmitter in Setup mode (Level 1).
        public const int READ_SERIAL_NUMBER = 183; // Returns transmitter-specific serial number
        //5.1.2 Level 1 – Setup Mode Commands
        public const int SET_BINARY_OUT = 10; //1 = Output data in Binary form(no ASCII conversion).
        public const int SET_SEND_TEMPERATURE = 13; //1 = Send Temperature with continuous out.
        public const int SET_USR_SCALING = 25; //1 = Turn user scale factors on.
        public const int SET_MULTINODE = 28; //1 = Multiple units are sharing the same line.
        public const int SET_FAHRENHEIT = 33; //1 = Return temperature in Fahrenheit instead of Celsius.
        public const int SET_TERMINAL_MODE = 44; //1 = Terminal mode, 0 = Embedded mode
        public const int SET_DELIM_CHAR = 83; //Set character used between samples in one buffer.
        public const int SET_MAX_NUM_FRAC_DIGITS = 84; //Set maximum number of digits past decimal point.
        public const int SET_SAMPLE_TIME = 85; //Sets the data acquisition time (in ms).
        public const int SET_NODE_ADDR = 86; //Set address for multinode operation.
        public const int SET_BAUD_RATE = 87; //Set the baud rate
        public const int SET_PARITY = 88; //Set the parity
        public const int SET_USR_SCALE_OFFSET = 123; //Write new user-set system offset value.
        public const int SET_USR_SCALE_GAIN = 124; //Write new user-set system gain factor.
        public const int RESTORE_DEFAULT_SETTINGS = 187; //Restore default factory settings
        public const int BASIC_ACCESS = 223; //Returns transmitter to operating level 0.
    }
}
