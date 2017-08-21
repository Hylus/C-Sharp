#define SCREEN_WIDTH 700
#define SCREEN_HEIGHT 600

#define ID_BUTTON1 1
#define ID_BUTTON2 2
#define ID_BUTTON3 3
#define ID_BUTTON4 4
#define ID_BUTTON5 5
#define ID_BUTTON6 6
#define ID_BUTTON7 7
#define ID_BUTTON8 8
#define ID_BUTTON9 9
#define ID_BUTTON0 0

#define ID_PLUS 11
#define ID_MINUS 12
#define ID_MNOZENIE 13
#define ID_DZIELENIE 14
#define ID_PRZECINEK 15
#define ID_ROWNASIE 16

#define ID_VALUEFIELD1 400
 
#include <windows.h>
#include <tchar.h>
 
TCHAR className[] = TEXT("NazwaKlasy");
TCHAR appName[] = TEXT("Stoperan");
 
HWND hwnd;
MSG msg;

/*

void Wpisz (HWND &hwnd, unsigned int milisekundy)
{
	unsigned int ms = 0, s = 0, min = 0;
	if (milisekundy / 60000 >= 1)
	{
		min = milisekundy / 60000;
		milisekundy = milisekundy - (60000 * min);
	}

	if (milisekundy / 1000 >= 1)
	{
		s = milisekundy / 1000;
		milisekundy = milisekundy - (1000* s);
	}

	ms = milisekundy;

	wchar_t Bufor[255];
	_swprintf (Bufor, L"%d : %d : %d", min , s , ms);
	SetWindowText (hwnd,Bufor);
}
 */
LRESULT CALLBACK WndProc(HWND hwnd, UINT msg, WPARAM wParam, LPARAM lParam)
{
	static RECT R;
	static HWND ValueField, BUTTON[10];
	static HWND DODAJ, ODEJMIJ, POMNOZ, PODZIEL, ROWNASIE;
 
    switch (msg)
	{
        case WM_CREATE:
		{
			 HINSTANCE &hInstance = ((LPCREATESTRUCT)lParam)->hInstance;

			 ValueField = CreateWindowEx (0,L"STATIC",L"00:00:000",WS_CHILD | WS_VISIBLE, 0, 0 , 0 ,0, hwnd, (HMENU)ID_VALUEFIELD1, hInstance,0);
			 if (ValueField==0)
			 {
				 MessageBox (hwnd,L"Problem z ValueField", className, MB_OK);
				 return 1;
			 }
			
			 
			 for (int i=0; i <10 ; i++)
			 {
				 wchar_t Bufor[11] = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
			//	 wchar_t Bufor[11] = { 1,2,3,4,5,6,7,8,9,0 };
			//	 	 wchar_t Bufor[11] = { "1","2","3","4","5","6","7","8","9","0" };
	    		 BUTTON[i] = CreateWindowEx (0,L"BUTTON",L"Bufor[i]",WS_CHILD | WS_VISIBLE, 0, 0 , 0 ,0, hwnd, (HMENU)ID_BUTTON1, hInstance,0);
				 if (!BUTTON[i])
				 {
					 MessageBox (hwnd,L"Problem z BUTTON", className, MB_OK);
					 return 1;
				 }
			 }
        }break;

        case WM_SIZE:
			{
            GetClientRect(hwnd, &R);         
            MoveWindow(ValueField, R.right / 3, R.bottom / 3, R.right / 7, R.bottom / 15, 1);
            MoveWindow(BUTTON[1], R.right / 3, R.bottom / 2.5 + 10, R.right / 7, R.bottom / 15, 1);
            MoveWindow(BUTTON[2], R.right / 2, R.bottom / 2.5 + 10, R.right / 7, R.bottom / 15, 1);
            MoveWindow(BUTTON[3], R.right / 2, R.bottom / 3, R.right / 7, R.bottom / 15, 1);
            }break;
 
        case WM_GETMINMAXINFO:
            ((MINMAXINFO*)lParam)->ptMinTrackSize.x = 550;
            ((MINMAXINFO*)lParam)->ptMinTrackSize.y = 400;
			((MINMAXINFO*)lParam)->ptMaxTrackSize.x = 1000;
			((MINMAXINFO*)lParam)->ptMaxTrackSize.y = 900;
            break;
 
        case WM_COMMAND:
            switch (wParam)
			{
                case ID_BUTTON1:
//                    Wpisz (ValueField, 1);
                    break;
 
                case ID_BUTTON2:
                    
                    break;
 
                case ID_BUTTON3:
 
                    break;
            }break;
           
        case WM_CLOSE: 
            DestroyWindow(hwnd);   
            break;
 
        case WM_DESTROY:
			{
				PostQuitMessage(0);
            }break;
 
        default:   
            return DefWindowProc(hwnd, msg, wParam, lParam);
    }
    return 0;
}
 
int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, LPSTR lpCmdLine, int nCmdShow)
{
    WNDCLASSEX wc;
    wc.cbSize = sizeof(WNDCLASSEX);
    wc.style = 0;
    wc.cbClsExtra = 0;
    wc.cbWndExtra = 0;
    wc.hInstance = hInstance;
    wc.hbrBackground = (HBRUSH)(COLOR_WINDOW + 1);
    wc.lpfnWndProc = WndProc;
    wc.lpszClassName = className;
    wc.lpszMenuName = NULL;
    wc.hIcon = LoadIcon(NULL, IDI_APPLICATION);
    wc.hIconSm = LoadIcon(NULL, IDI_APPLICATION);
    wc.hCursor = LoadCursor(NULL, IDC_ARROW);
 
    if (RegisterClassEx(&wc) == 0)
	{
        MessageBox(NULL, L"wc", className, MB_OK);
        return 1;
    }
 
    hwnd = CreateWindowEx(WS_EX_APPWINDOW | WS_EX_CLIENTEDGE, className, appName, WS_OVERLAPPEDWINDOW, CW_USEDEFAULT, CW_USEDEFAULT, SCREEN_WIDTH, SCREEN_HEIGHT, 0, 0, hInstance, 0);
    if (hwnd == NULL)
	{
        MessageBox(NULL, L"hwnd", className, MB_OK);
        return 1;
    }
 
    ShowWindow(hwnd, nCmdShow);
    UpdateWindow(hwnd);
 
    while (GetMessage(&msg, NULL, 0, 0) > 0)
    {
        TranslateMessage(&msg);
        DispatchMessage(&msg);
    }
 
    UnregisterClass(className, hInstance);
 
    return msg.wParam;
}