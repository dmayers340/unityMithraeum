/*
*Connect to unity and start fan
*https://medium.com/@yifeiyin/communication-between-arduino-and-unity-9fdcccc2be3f
*/

//This number is whatever the fan is connected to on Arduino, I like the number 8
int fanConnectionPin = 8; 

int testing = 0;
//boolean to tell if fan is on or off, start with fan off
bool fanOn = false; 

//Standard Arduino start https://www.arduino.cc/en/serial/begin
void setup() 
{
    Serial.begin(9600); //starts serial port at 9600 baud (bits per second)
    Serial.println("Connection Successful!");
    
    pinMode(LED_BUILTIN, OUTPUT);
    pinMode(fanConnectionPin, OUTPUT);
}

//https://www.arduino.cc/reference/en/language/functions/digital-io/digitalwrite/
void loop() 
{
   testing = testing + 1;
   if(testing == 10)
   {
      testing = 0;
   }

   Serial.println(testing);
   delay(1000);
   
   // digitalWrite(fanConnectionPin, HIGH);
    digitalWrite(LED_BUILTIN, HIGH);
    delay(1000);    
}

