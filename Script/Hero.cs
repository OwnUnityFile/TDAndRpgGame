using UnityEngine;
using System.Collections;
//英雄的管理类
public class Hero : MonoBehaviour
{
    Animator _ani;
    GameObject _hero;      //英雄的模型
    Camera _camera;
    Camera _camera2;
    
    Vector3 _cameraCha;
    float _camera2High;
    
    void Awake()
    {
        _ani = GetComponent<Animator>();
        _camera2 = GameObject.Find("Camera").GetComponent<Camera>();
        _camera = GameObject.Find("Main Camera").GetComponent<Camera>();
        
        _camera2High = _camera2.transform.position.y - transform.position.y;
        
        _cameraCha = _camera.transform.position - transform.position;
        
    }
    /// <summary>
    /// 英雄技能攻击使用
    /// </summary>
    void HeroHit()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            _ani.SetBool(HashIDs.Attack, true);
        }
       // _ani.SetBool(HashIDs.Attack, false);
    }
    // Use this for initialization
    //bool isMove = false;
    Vector3 endPoint;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            _ani.SetBool(HashIDs.Attack, true);
        }
        if(Input.GetKeyUp(KeyCode.K))
        {
        _ani.SetBool(HashIDs.Attack, false);
        }
        float ver = Input.GetAxis("Vertical");
        float hor = Input.GetAxis("Horizontal");
        
        if (ver > 0)
        {
            _ani.SetFloat(HashIDs.speed, 5.5f, 0.1f, Time.deltaTime);
            transform.Translate(new Vector3(0, 0, ver) * Time.deltaTime * 5f);
            
        }
        else
        {
            _ani.SetFloat(HashIDs.speed, 0);
        }
        transform.Rotate(new Vector3(0, hor, 0) * 15f);

        
       
    
            
        
        
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        //    RaycastHit _hit;
        //    if (Physics.Raycast(ray, out _hit))
        //    {
        //        if (_hit.collider.tag == "Global")
        //        {

        //            endPoint = _hit.point;
        //            endPoint.y = endPoint.y+transform.position.y/2;
        //            isMove = true;
        //        }
        //    }
        //}
        //if (isMove)
        //{
        //    transform.LookAt(endPoint);
        //    _ani.SetFloat(HashIDs.speed, 5.5f, 0.1f, Time.deltaTime);
        //    transform.position = Vector3.Lerp(transform.position, endPoint, Time.deltaTime);
        //}
        //if (endPoint == transform.position)
        //{
        //    isMove = false;
        //}
    }
    void LateUpdate()
    {

        _camera.transform.position = transform.position + _cameraCha;
        _camera2.transform.position = transform.position + Vector3.up * _camera2High;
        
    }
    

    


   
    // Update is called once per frame

}
