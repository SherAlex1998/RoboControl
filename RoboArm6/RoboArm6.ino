#include <ArduinoQueue.h>
#include <Servo.h>
#include <math.h>

class ServoClass
{
  private:
  
  Servo servo;
  bool isMooving;
  int currentAngle;
  int angleStep;
  int delayTime;
  int targetAngle;

  public:

  ServoClass(int pin, int currentAngle)
  {
    this->currentAngle = currentAngle;
    this->targetAngle = currentAngle;
    AttachServo(pin);
    servo.write(currentAngle);
    isMooving = false;
    delayTime = 6;
  }
  
  void AttachServo(int pin)
  {
    servo.attach(pin);
  }

  void Write(int targetAngle)
  {
    servo.write(targetAngle);
  }

  void SetTargetAngle(int targetAngle)
  {
    this->targetAngle = targetAngle;
  }

  void Moove()
  {
    if(currentAngle != targetAngle)
    {
      angleStep = (targetAngle - currentAngle) / abs(targetAngle - currentAngle);
      currentAngle += angleStep;
      servo.write(currentAngle);
      delay(delayTime);
    }
  }
};

ServoClass* horizonServo; // горизонтальное вращение. Нативное положение = 90. Меняется от 0 до 180.
ServoClass* foreArmServo; // предплечье (звено 1)
ServoClass* armServo; // рука (звено 2)

ServoClass* brushServo; // кисть (звено 3)
ServoClass* grabServo; // клешня

char serialCommand = 'c';

void setup()
{
  horizonServo = new ServoClass(3, 90);
  foreArmServo = new ServoClass(4, 140);
  armServo = new ServoClass(5, 90);
  brushServo = new ServoClass(6, 90);
  grabServo = new ServoClass(7, 30);
  Serial.begin(9600);
}

void ProcessMoove()
{
  horizonServo->Moove();
  foreArmServo->Moove();
  armServo->Moove();
  brushServo->Moove();
  grabServo->Moove();
}

void loop() 
{
  double doubleArg;
  int intArg;
  ProcessMoove();
   if (Serial.available()) 
   {
        serialCommand = Serial.read();
        switch(serialCommand)
        {
          case 'd':
            intArg = Serial.parseInt();
            Serial.print("Arg: ");
            Serial.println(intArg);
            if(intArg >= 0 && intArg <= 180)
            {
              horizonServo->SetTargetAngle(intArg);
            } 
            break;
         case 'r':
            intArg = Serial.parseInt();
            Serial.print("Arg: ");
            Serial.println(intArg);
            if(intArg >= 0 && intArg <= 180)
            {
              foreArmServo->SetTargetAngle(intArg);
            } 
            break;
         case 'l':
            intArg = Serial.parseInt();
            Serial.print("Arg: ");
            Serial.println(intArg);
            if(intArg >= 0 && intArg <= 180)
            {
              armServo->SetTargetAngle(intArg);
            } 
            break;
         case 'b':
            intArg = Serial.parseInt();
            Serial.print("Arg: ");
            Serial.println(intArg);
            if(intArg >= 0 && intArg <= 180)
            {
              brushServo->SetTargetAngle(intArg);
            } 
            break;
         case 'g':
            intArg = Serial.parseInt();
            Serial.print("Arg: ");
            Serial.println(intArg);
            if(intArg >= 0 && intArg <= 180)
            {
              grabServo->SetTargetAngle(intArg);
            } 
            break;
         case 'o':
            Serial.print("Open Grab: ");
            grabServo->SetTargetAngle(30);
            break;
         case 'c':
            Serial.print("Close Grab: ");
            if(intArg >= 0 && intArg <= 180)
            {
              grabServo->SetTargetAngle(80);
            } 
            break;
         case 'n':
            Serial.read();
        }
    }
}
