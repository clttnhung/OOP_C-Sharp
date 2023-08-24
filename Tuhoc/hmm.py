import speech_recognition
import pyttsx3
from datetime import datetime

robot_nghe = speech_recognition.Recognizer()
robot_rep=""

with speech_recognition.Microphone() as mic:
    sayhi = "tao nghe đây"
    robot_mom = pyttsx3.init()
    robot_mom.say(sayhi)
    robot_mom.runAndWait()
    print(sayhi)
    print('-----')
    audio = robot_nghe.listen(mic)
    wait = "đợi tao tí..."
    print("robot : " + wait)
    robot_mom = pyttsx3.init()
    robot_mom.say(wait)
    robot_mom.runAndWait()
try:
    robot_mom =  robot_nghe.recognize_google(audio)
except:
    robot_mom = "..."

print("you: " ,robot_mom)

if robot_mom == "hello":
    robot_rep = "hello con cặc"
elif robot_mom == "...":
    robot_rep ="mày nói con cặc gì đó đéo nghe?"
elif robot_mom == "how":
    robot_rep= "tao khỏe vãi lồn"
elif robot_mom == "today":
    date_time = datetime.today()
    robot_rep= date_time.strftime("%d %B, %Y")
elif robot_mom == "now":
    date_time = datetime.now()
    robot_rep= date_time.strftime(" %H:%M:%S")
elif robot_mom == "bye":
    robot_rep= "cút đi thằng chó, ko tiễn"
else:
    robot_rep = robot_mom

print("robot : " + robot_rep)

robot_mom = pyttsx3.init()
robot_mom.say(robot_rep)
robot_mom.runAndWait()




