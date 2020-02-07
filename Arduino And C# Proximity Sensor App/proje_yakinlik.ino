const int trigPin = 5, echoPin = 6;
long uzaklik;
long sure;

int maximumRange = 50;
int minimumRange = 0;
void setup() {
  pinMode(trigPin, OUTPUT);
  pinMode(echoPin, INPUT);
  Serial.begin(9600);
}
void loop() {
  int olcum = mesafe(maximumRange, minimumRange);
  Serial.println(olcum);
}

  int mesafe(int maxrange, int minrange)
{
  long duration, distance;

  digitalWrite(trigPin, LOW);
  delayMicroseconds(2);
  digitalWrite(trigPin, HIGH);
  delayMicroseconds(10);
  digitalWrite(trigPin, LOW);

  duration = pulseIn(echoPin, HIGH);
  distance = duration / 2 / 29.1;
  delay(50);

  if (distance >= maxrange || distance <= minrange)
    return 0;
  return distance;
}
