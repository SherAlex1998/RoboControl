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

ServoClass* grabServo;// Клешня - нативное положение = 90
ServoClass* leftServo; // левый привод нативное положение = 160
ServoClass* rightServo; // правый привод нативное положение = 20. Меняется от 20 до 90.
ServoClass* horizonServo; // горизонтальное вращение. Нативное положение = 90. Меняется от 0 до 180.

char serialCommand = 'c';

void setup()
{
  horizonServo = new ServoClass(7, 90);
  grabServo = new ServoClass(4, 95);
  leftServo = new ServoClass(5, 70); // от 50 до 110
  rightServo = new ServoClass(6, 20);
  Serial.begin(9600);
}

void ProcessMoove()
{
  horizonServo->Moove();
  rightServo->Moove();
  leftServo->Moove();
  grabServo->Moove();
}
/*
void SetTargetAngleToLeftServo(double rate) // Высчитывает значение угла для растяжения
{
  int targetAngle = 100 - (int)(rate * 40);
  leftServo->SetTargetAngle(targetAngle);
}
*/
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
          case 'l':
            //doubleArg = Serial.parseFloat();

            //doubleArg = constrain(doubleArg, 0, 1);
            //Serial.print("Arg: ");
            //Serial.println(doubleArg);
            //SetTargetAngleToLeftServo(doubleArg);
            intArg = Serial.parseInt();
            Serial.print("Arg: ");
            Serial.println(intArg);
            leftServo->SetTargetAngle(intArg);
            break;
         case 'r':
            intArg = Serial.parseInt();
            //Serial.print("Arg: ");
            Serial.println(intArg);
            if(intArg >= 20 && intArg <= 90)
            {
              rightServo->SetTargetAngle(intArg);
            }  
            break; 
    
          case 'o':
            //Serial.println(serialCommand);
            //intArg = Serial.parseInt();
            grabServo->SetTargetAngle(70);
            break;
          case 'c':
            //Serial.println(serialCommand);
            //intArg = Serial.parseInt();
            grabServo->SetTargetAngle(95);
            break;
            /*
          case 'l':
            //intArg = Serial.parseInt();
            //Serial.println(intArg);
            //leftServo.write(intArg);
            doubleArg = Serial.parseFloat();
            Serial.println(doubleArg);
            doubleArg = constrain(doubleArg, 0, 1);
            MooveLeftRig(doubleArg);
            //leftServo.write(intArg);
            break;
          case 'r':
            intArg = Serial.parseInt();
            //Serial.print("Arg: ");
            Serial.println(intArg);
            if(intArg >= 20 && intArg <= 90)
            {
              rightCommandQueue.enqueue(intArg);
            }  
            break; 
            */
          case 'n':
            Serial.read();
        }
    }
}
