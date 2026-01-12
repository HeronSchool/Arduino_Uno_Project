int Led_Pin = 9;
int Switch_Pin = 5;
int Analog_Pin = A5;

void setup() {
  Serial.begin(9600);
  //pinMode(Switch_Pin, INPUT_PULLUP);
  pinMode(Led_Pin, OUTPUT);
}

void loop() {
  int val = analogRead(Analog_Pin); // 0V (0) ~ 5V (1023)

  Serial.println(val); // send data

  val = map(val, 0, 1023, 0, 255); // 0 (0) ~ 1023 (255)
  analogWrite(Led_Pin, val); // Pulse Width Modulation (duration)

  delay(100);
}
