import datetime
from time import gmtime, strftime

def currentDateTime():
    dateTimeCurrent = datetime.datetime.now()
    return str(dateTimeCurrent)

def GeneratetCurrentDateTime(format ="%a_%d_%m_%Y_%H_%M_%S"):
    return strftime(format, gmtime())

if (__name__ == "__main__"):
    print(currentDateTime())
    print(GeneratetCurrentDateTime())
