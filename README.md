# Stickman-Ragdoll-Tutorial
 
**This is the code for my YouTube video: *How to Make an Active 2D Stickman Ragdoll in Unity | Balance, Run, Jump***

https://youtu.be/q_enFap8Pr8
 
In this video, I go over from start to finish making an active 2D ragdoll in Unity. I teach you how to make the ragdoll character in Photoshop, import and rig the character in Unity, and script the run, jump, and balance. Enjoy!

This Unity project is licensed under the MIT License, read more about usability under in the LICENSE file: https://github.com/craftyclawboom/Stickman-Ragdoll-Tutorial/blob/82c8ff8f4606540adfeac0100f2eac17211e713f/LICENSE

# Что переделать
Надо переписать следуйщие модули
- все в папке *Assets\Scripts\Monetization*
- все в папке *Assets\Scripts\SDK*
Нужно посмотреть что там для RuStore

Assets\Scripts\BridgeAndroid.cs
Реализовать все необходимое для(за основу можно взять старую реализацую, но папки с изначальным кодом надо отдельно открывать Assets\InstantGamesBridge\...):
 - advertisement
 - storage
 - player
 - platform
образение к этой 4 были замечены в использовании другими модулями, если что-то нужно добавить, это надо добавить.

SaveManager.cs - нужно раскомментить, когда реализуется Bridge, конечно если в итоге не придется переписывать логику.

Есть часть модулей без логики: Enemy.cs, Ground.cs.

Сделал тестовую сборку в текущем состоянии, она запускается не более. 

Скорее всего есть много упущеных деталей.
