using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossscenechange : MonoBehaviour
{
    GameObject pointM;
    pointmanager pointmanager;
    //�ǂ̃{�X���o�������邩�ƁA�~�T�C���̌������߂邽�߂̔���������ł��Ă���܂���B
    // Start is called before the first frame update
    void Start()
    {
        pointM = GameObject.Find("pointmanager");
        pointmanager = pointM.GetComponent<pointmanager>();
        int total = 0;
        for (int i = 0; i < 10; i++)
        {
            total = total + pointmanager.chebucount[i];
        }
        //�����_�ł̃X�R�A���ɂ���ė^����~�T�C���̐���ς���
        //�z��̉��ԖڂƔx���o�[���ǂ̈ʒu�ɂ��邩�ɂ���ď�����ς���B
        //�x���R���g���[���[���Q�Ƃ���悤�ɂ��Ȃ��Ƃ����Ȃ��I�I
        //���̏���ruirui�̃{�X��ʂւ����Ă������߂�playerprefs�Ńf�[�^�̎󂯓n��������H����Ƃ��A�󂳂�Ȃ��I�u�W�F�N�g�ɒl���������Ƃ����B�����͗v���k�B
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
