--主入口函数。从这里开始lua逻辑
function Main()					
	local Color = UnityEngine.Color
	local GameObject = UnityEngine.GameObject
	local ParticleSystem = UnityEngine.ParticleSystem                   
	
	local go = GameObject('go')
	go:AddComponent(typeof(ParticleSystem))
	local node = go.transform
	node.position = Vector3.one                  
	print('hello')                 

end

--场景切换通知
function OnLevelWasLoaded(level)
	collectgarbage("collect")
	Time.timeSinceLevelLoad = 0
end

function OnApplicationQuit()
end