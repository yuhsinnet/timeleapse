mkdir C:\Users\x7870\Pictures\TimeLeapseVideo
cd C:\Users\x7870\Pictures\TimeLeapsecam1
ffmpeg -f concat -r 2 -i list.txt -s:v 1920x1080 -c:v libx264 -crf 35 -pix_fmt yuv420p C:\Users\x7870\Pictures\TimeLeapseVideo\camera1-1m.avi

cd C:\Users\x7870\Pictures\TimeLeapsecam2
ffmpeg -f concat -r 2 -i list.txt -s:v 1920x1080 -c:v libx264 -crf 35 -pix_fmt yuv420p C:\Users\x7870\Pictures\TimeLeapseVideo\camera2-1m.avi

REM cd C:\Users\x7870\Pictures\TimeLeapsecam2
REM ffmpeg -f concat -r 2 -i list.txt -s:v 1920x1080 -c:v libx264 -crf 35 -pix_fmt yuv420p C:\Users\x7870\Pictures\TimeLeapseVideo\camera2-11m.avi

REM cd C:\Users\x7870\Pictures\TimeLeapsecam2-12
REM ffmpeg -f concat -r 2 -i list.txt -s:v 1920x1080 -c:v libx264 -crf 35 -pix_fmt yuv420p C:\Users\x7870\Pictures\TimeLeapseVideo\camera2-12m.avi

REM cd C:\Users\x7870\Pictures\TimeLeapsecam2-12
REM ffmpeg -f concat -r 2 -i list.txt -s:v 1920x1080 -c:v libx264 -crf 35 -pix_fmt yuv420p C:\Users\x7870\Pictures\TimeLeapseVideo\camera11.avi

REM cd C:\Users\x7870\Pictures\TimeLeapsecam12
REM ffmpeg -f concat -r 2 -i list.txt -s:v 1920x1080 -c:v libx264 -crf 35 -pix_fmt yuv420p C:\Users\x7870\Pictures\TimeLeapseVideo\camera12.avi
pause