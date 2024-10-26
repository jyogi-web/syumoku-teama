using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField,TextArea(1,2)] string[] texts;//Unity��œ��͂���string�̔z��
    int textNumber;//���Ԗڂ�texts[]��\�������邩
    string displayText;//�\��������string
    int textCharNumber;//�������ڂ�displayText�ɒǉ����邩
    int displayTextSpeed; //�S�̂̃t���[�����[�g�𗎂Ƃ��ϐ�
    bool click;//�N���b�N����
    bool textStop; //�e�L�X�g�\�����n�߂邩
    bool isSelifuEnd = true;//�Z���t���I�������ɏ������������ǂ���
    float count1second = 0; //1�b�Ԑ�����
    public GameObject serifu;
    public Text serifutext;
    void Start()
    {
        serifutext= GetComponent<Text>();
    }
    void Update()
    {
            if (textStop == false) //�e�L�X�g��\��������if��
            {
                displayTextSpeed++;
                if (displayTextSpeed % 9 == 0)//7s��Ɉ��v���O���������s����if��
                {

                    if (textCharNumber != texts[textNumber].Length)//����text[textNumber]�̕�����̕������Ō�̕�������Ȃ����
                    {
                        displayText = displayText + texts[textNumber][textCharNumber];//displayText�ɕ�����ǉ����Ă���
                        textCharNumber = textCharNumber + 1;//���̕����ɂ���
                    }
                    else//����text[textNumber]�̕�����̕������Ō�̕�����������
                    {
                        if (click == true)//�N���b�N���ꂽ����
                        {
                            displayText = "";//�\�������镶���������
                            textCharNumber = 0;//�����̔ԍ����ŏ��ɂ���
                            textNumber = textNumber + 1;//���̃Z���t�ɂ���
                        }
                        else //����texts[]���Ō�̃Z���t�ɂȂ�����
                        {
                            if (isSelifuEnd) {
                                
                                GameObject startcount = GameObject.Find("Startcount");
                                timer timer = startcount.GetComponent<timer>();
                                timer.StartCoroutine("CountDown");
                                
                                isSelifuEnd = false;
                            }
                            count1second += Time.deltaTime;
                            if (count1second >= 0.15)
                            {
                                serifutext.enabled = false;
                                //displayText = ""; //�\�������镶���������
                                textCharNumber = 0; //�����̔ԍ����ŏ��ɂ���
                                textStop = true; //�Z���t�\�����~�߂�
                            }
                    }
                    }

                    this.GetComponent<Text>().text = displayText;//��ʏ��displayText��\��
                    click = false;//�N���b�N���ꂽ���������
                }
                if (Input.GetMouseButton(0))//�}�E�X���N���b�N������
                {
                    click = true; //�N���b�N���ꂽ����ɂ���
                }
            }
    }
}
