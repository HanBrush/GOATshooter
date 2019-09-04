using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ControllerforStartScene : MonoBehaviour {
    private LineRenderer lineRenderer;
    private Transform tr; //3 좌표를 가지고 옴

    //레이저의 거리
    private float range = 10.0f; //10m

    // public Color defaultColor = Color.white;

    //머리리얼 로드
    private Material mt;

    //포인터 프리팹을 로드
    private GameObject pointerPrefab;
    //동적으로 생성해서 라인렌더러 끝에 위치시킬 객체
    private GameObject pointer;

    //Raycast 했을 때 충돌한 지점의 점보를 반환할 구조체(Structure - "class와 비슷하지만 가벼운 것")
    private RaycastHit hit;

    // public float powerIncreaseDegree = 1.0f;

    // GameObject movingB;

    // bool hasBall = true;

    private GameObject prevButton;
    private GameObject currButton;

    // public GameObject courtLight;

    void Start () {

        tr = GetComponent<Transform> ();
        //프로젝트 뷰의 Resources 폴더에 있는 Line 에셋을 로드. 여기서 "Line"은 직접 만든 material 이름과 동일해야합니다
        mt = Resources.Load<Material> ("Line");
        pointerPrefab = Resources.Load<GameObject> ("Pointer");
        CreateLine ();

    }

    void Update () {

        // CreateLine ();
        //Physics.Raycast(광선의 발사원점, 발사방향, 결과값, max거리)
        if (Physics.Raycast (tr.position, tr.forward, out hit, range)) {
            //라인렌더러의 끝좌표 보정
            lineRenderer.SetPosition (1, new Vector3 (0, 0, hit.distance)); //hit.distance : laser가 맞은 지점까지의 거리
            //포인터의 끝좌표를 보정
            pointer.transform.localPosition = tr.localPosition - Vector3.forward * 0.001f + new Vector3 (0, 0, hit.distance);
            //포인터의 각도 수정
            pointer.transform.rotation = Quaternion.LookRotation (hit.normal); //hit.normal: 법선벡터 

            //--------------------------------------UI 이벤트 모드창 색깔 변경
            PointerEventData data = new PointerEventData (EventSystem.current);
            if (hit.collider.gameObject.layer == 10) {
                currButton = hit.collider.gameObject;
                if (currButton != prevButton) {

                    ExecuteEvents.Execute (currButton, data, ExecuteEvents.pointerEnterHandler);
                    
                    ExecuteEvents.Execute (prevButton, data, ExecuteEvents.pointerExitHandler);

                   
                }

                if(OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
                    {ExecuteEvents.Execute (currButton, data, ExecuteEvents.pointerClickHandler);}

  
                prevButton = currButton;

     

            } 
            else {
                ChangeModeColorBack ();
            }

            //----------------------------------------콘트롤러 홀드 시 게이지 변화
            // if (OVRInput.Get (OVRInput.Button.PrimaryIndexTrigger))
            // // if(Input.GetButton("Fire1"))
            // {
            //     if (hit.collider.tag.Equals ("BALL")) {
            //         movingB = hit.collider.gameObject;

            //         if (movingB != null) {
            //             GaugeChange ();
            //             MovingBall ();

            //         }
            //     }

            // }
        } else //raycast가 아무것에도 맞지 않았을 때 
        {

            pointer.transform.localPosition = tr.localPosition + new Vector3 (0, 0, range);
            pointer.transform.LookAt (tr.position - pointer.transform.localPosition); //LookAt 은 해당 물체의 방향으로 각도를 틀어준다
        }

        // if (OVRInput.GetUp (OVRInput.Button.PrimaryIndexTrigger))
        // // if(Input.GetButtonUp("Fire1"))
        // {

        //     ReleaseBall ();
        //     circleGauge._gaugeValue = 0;
        //     powerIncreaseDegree = 1.0f;

        // }

    }

    // Update is called once per frame
    void CreateLine () {
        lineRenderer = this.gameObject.AddComponent<LineRenderer> ();

        lineRenderer.useWorldSpace = false;
        lineRenderer.widthMultiplier = 0.005f;
        lineRenderer.SetPosition (1, new Vector3 (0, 0, range));
        //머티리얼을 생성해서 대입
        // Material mt = new Material(Shader.Find("Unlit/Color"));
        // mt.color = defaultColor;
        lineRenderer.sharedMaterial = mt;

        //포인터 생성
        pointer = Instantiate (pointerPrefab, lineRenderer.GetPosition (1), Quaternion.identity, transform);
    }

    // void GaugeChange () {
    //     circleGauge._gaugeValue += powerIncreaseDegree;

    //     if (circleGauge._gaugeValue >= 100) {
    //         powerIncreaseDegree = -1.0f;
    //     }

    //     if (circleGauge._gaugeValue <= 0) {
    //         powerIncreaseDegree = 1.0f;
    //     }

    // }

    // void MovingBall () {

    //     if (hasBall != false) {
    //         movingB.transform.SetParent (this.transform);
    //         Rigidbody rb = movingB.GetComponent<Rigidbody> ();
    //         rb.isKinematic = true;
    //         hasBall = false;
    //     }
    // }

    // void ReleaseBall () {

    //     float power = circleGauge._gaugeValue * 3.5f;
    //     Rigidbody rb = movingB.GetComponent<Rigidbody> ();

    //     // movingB.transform.rotation = Quaternion.Euler(movingB.transform.rotation.x,movingB.transform.rotation.y,0.0f);

    //     Vector3 movement = transform.forward;

    //     movingB.transform.SetParent (null);
    //     rb.isKinematic = false;
    //     rb.AddForce (movement * power);
    //     hasBall = true;
    // }

    void ChangeModeColorBack () {
        PointerEventData data = new PointerEventData (EventSystem.current);

        if (prevButton != null) {
            ExecuteEvents.Execute (prevButton, data, ExecuteEvents.pointerExitHandler);
            prevButton = null;
        }

    }

}