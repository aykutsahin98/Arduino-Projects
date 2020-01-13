#define kirmizi 9
#define yesil 10
#define mavi 11
 void setup() {
   Serial.begin(9600);
 }
 void loop() {
 if (Serial.available() == 3)
   {
     analogWrite(kirmizi, 255 - Serial.read());
     analogWrite(yesil, 255 - Serial.read());
     analogWrite(mavi, 255 - Serial.read());
    
    }
 }
