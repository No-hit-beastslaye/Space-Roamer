using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_main : MonoBehaviour
{

    private Transform player;
    private Camera mainCamera;

    public Vector2 margin = new Vector2(1, 1); // If the player stays inside this margin, the camera won't move.
    public Vector2 smoothing = new Vector2(3, 3); // The bigger the value, the faster the camera is.

    public BoxCollider2D CameraBounds;

    private Vector3 min, max;

    public bool isFollowing;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
    }

    private void Start()
    {
        min = CameraBounds.bounds.min;
        max = CameraBounds.bounds.max;
        isFollowing = true;
        mainCamera = GetComponent<Camera>();

        if (Application.loadedLevelName != "Space Roamer")
        {
            mainCamera.backgroundColor = Color.black;
        }
    }

    // Update is called once per frame
    void Update()
    {
        var x = transform.position.x;
        var y = transform.position.y;

        if (isFollowing)
        {
            if (Mathf.Abs(x - player.position.x) > margin.x)
            {
                x = Mathf.Lerp(x, player.position.x, smoothing.x * Time.deltaTime);
            }

            if (Mathf.Abs(y - player.position.y) > margin.y)
            {
                y = Mathf.Lerp(y, player.position.y, smoothing.y * Time.deltaTime);
            }
        }

        // ortographicSize is the half of the height of the Camera.
        var cameraHalfWidth = mainCamera.orthographicSize * ((float)Screen.width / Screen.height);

        x = Mathf.Clamp(x, min.x + cameraHalfWidth, max.x - cameraHalfWidth);
        y = Mathf.Clamp(y, min.y + mainCamera.orthographicSize, max.y - mainCamera.orthographicSize);

        transform.position = new Vector3(x, y, transform.position.z);
    }

    //PixelPerfectScript
    public static float RoundToNearestPixel(float unityUnits, Camera viewingCamera)
    {
        float valueInPixels = (Screen.height / (viewingCamera.orthographicSize * 2)) * unityUnits;
        valueInPixels = Mathf.Round(valueInPixels);
        float adjustedUnityUnits = valueInPixels / (Screen.height / (viewingCamera.orthographicSize * 2));
        return adjustedUnityUnits;
    }

    private void LateUpdate()
    {
        Vector3 newPos = transform.position;
        Vector3 roundPos = new Vector3(RoundToNearestPixel(newPos.x, mainCamera), RoundToNearestPixel(newPos.y, mainCamera), newPos.z);
        transform.position = roundPos;
    }

    public void UpdateBounds()
    {
        min = CameraBounds.bounds.min;
        max = CameraBounds.bounds.max;
    }

    //Source: https://forum.unity.com/threads/camera-follows-player-but-stops-at-the-corners-of-the-map.438811/ 
    //1ste comment.
}
